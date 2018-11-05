﻿// Require packages.
var util = require('util');
var WildEmitter = require('wildemitter');
var webrtcSupport = require('webrtcsupport');
var mockconsole = require('mockconsole');
var localMedia = require('localmedia');
var WebRtcAdapter = require('./webrtcadapter');

/**
 * WebRTC prototype.
 * 
 * WebRTC controls the interaction between the
 * adapter and user configuration.
 * 
 * @param {Object}   webRtcOptions  A collection of options.
 *         
 * @example                         
 *  options = { 
 *      debug: true,
 *      signallingURL: "wss://127.0.0.1:443",
 *      peerConnectionConfiguration: {
 *          iceServers: [ 
 *		        { 
 *                  "urls": "stun:stun.l.google.com:19302"
 *			    },
 *              {
 *			        "urls": "turn:127.0.0.1:19305?transport=udp",
 *			        "username": "username",
 *			        "credential": "password"
 *		        },
 *		        {
 *			        "urls": "turn:127.0.0.1:19305?transport=tcp",
 *			        "username": "username",
 *			        "credential": "password"
 *		        }
 *	        ]
 *      },
 *      peerConnectionConstraints: {
 *          optional: []
 *      },
 *      receiveOfferMedia: {
 *          offerToReceiveAudio: 1,
 *          offerToReceiveVideo: 1
 *      } 
 *  }
 */
function WebRTC(webRtcOptions) {
	
	// local.
    var self = this;
    this.closed = false;
    var item;
    var options = webRtcOptions || {};

    var config = this.config = {
        debug: false,

        // Receive offer media config.
        receiveOfferMedia: {
            offerToReceiveAudio: 1,
            offerToReceiveVideo: 1
        },

        // Local video settings.
        localVideo: {
            autoplay: true,
            mirror: true,
            muted: true
        }
    };

    // Log nothing by default, following "the rule of silence":
    // http://www.linfo.org/rule_of_silence.html
    this.logger = function () {

        // Assume that if you're in debug mode and you didn't
        // pass in a logger, you actually want to log as much as
        // possible.
        if (webRtcOptions.debug) {
            return webRtcOptions.logger || console;
        } 
        else {
            // Use your logger which should have its own logic
			// for output. Return the no-op.
            return webRtcOptions.logger || mockconsole;
        }
    }();
    var myLogger = this.logger;

    // set our config from options
    for (item in options) {
        if (options.hasOwnProperty(item)) {
            this.config[item] = options[item];
        }
    }

    // attach detected support for convenience
    this.capabilities = webrtcSupport;

    // Call WildEmitter constructor.
    WildEmitter.call(this);

    // instantiate our main WebRTC helper
    // using same logger from logic here
    webRtcOptions.logger = myLogger;
    webRtcOptions.debug = false;

    // Create the webrtc adapter.
    this.webrtcadapter = new WebRtcAdapter(webRtcOptions);

    // Proxy events from WebRtcAdapter
    this.webrtcadapter.on('*', function () {
        self.emit.apply(self, arguments);
    });

    // log all events in debug mode
    if (config.debug) {
        this.on('*', this.logger.log.bind(this.logger, 'WebRTC event:'));
    }

    // Signalling event.
    this.webrtcadapter.on('signallingEventOpen', function (text, signalling, arg) {
        var argum = {
            open: true,
            text: text
        };
        self.emit('connectionOpen', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventError', function (text, signalling, arg) {
        var argum = {
            error: true,
            data: arg.data,
            text: text
        };
        self.emit('connectionError', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventClose', function (text, signalling, arg) {
        var argum = {
            close: true,
            text: text
        };
        self.emit('connectionClose', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventErrorDetails', function (text, signalling, arg) {
        var argum = {
            error: arg,
            text: text
        };
        self.emit('signalError', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventApplications', function (text, signalling, arg) {
        var argum = {
            list: arg,
            text: text
        };
        self.emit('signalApplications', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventUniques', function (text, signalling, arg) {
        var argum = {
            list: arg,
            text: text
        };
        self.emit('signalUniques', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventGroups', function (text, signalling, arg) {
        var argum = {
            list: arg,
            text: text
        };
        self.emit('signalGroups', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventSettings', function (text, signalling, arg) {
        var argum = {
            setting: arg,
            text: text
        };
        self.emit('signalSettings', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventAvailable', function (text, signalling, arg) {

        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            available: arg.contactAvailable,
            text: text
        };

        // Emit the message.
        self.emit('signalAvailable', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventSelfAvailable', function (text, signalling, arg) {

        var argum = {
            available: arg.contactAvailable,
            text: text
        };

        // Emit the message.
        self.emit('signalSelfAvailable', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventMessage', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            message: arg.contactMessage,
            text: text
        };

        // Emit the message.
        self.emit('signalMessage', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventState', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            state: arg.contactState,
            text: text
        };

        // Emit the message.
        self.emit('signalState', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventDetails', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        contact.setContactDetails(arg.clientDetails);

        var argum = {
            contact: contact,
            details: arg.clientDetails,
            text: text
        };

        // Emit the message.
        self.emit('signalDetails', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventJoinConferenceOffer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            conference: arg.conference,
            text: text
        };

        // Emit the message.
        self.emit('signalJoinConferenceOffer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventJoinConferenceAnswer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            conference: arg.conference,
            text: text
        };

        // Emit the message.
        self.emit('signalJoinConferenceAnswer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventSDP', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = null;

        // If file transfer or data channel.
        if (arg.isData) {
            // Get data contact.
            contact = self.createContactData(arg.contactUniqueID, arg.contactApplicationID);
        }
        else {
            contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        }

        // Set the remote description.
        contact.setRemoteDescription(arg.sdp)
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventCandidate', function (text, signalling, arg) {

        // Get the contact.
        var contact = null;

        // If file transfer or data channel.
        if (arg.isData) {
            // Get data contact.
            contact = self.createContactData(arg.contactUniqueID, arg.contactApplicationID);
        }
        else {
            contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        }

        // Set the ICE candidate.
        contact.addIceCandidate(arg.candidate)
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventOffer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            text: text
        };

        // Emit the message.
        self.emit('signalOffer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventAnswer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            text: text
        };

        // Emit the message.
        self.emit('signalAnswer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventFileOffer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContactData(arg.contactUniqueID, arg.contactApplicationID);
        contact.setFileInfo(arg.name, arg.size, arg.type, arg.lastModified);
        var argum = {
            contact: contact,
            name: arg.name,
            size: arg.size,
            text: text
        };

        // Emit the message.
        self.emit('signalFileOffer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventFileAnswer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContactData(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            text: text
        };

        // Emit the message.
        self.emit('signalFileAnswer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventNoAnswer', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            text: text
        };

        // Emit the message.
        self.emit('signalNoAnswer', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventEndCall', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            text: text
        };

        // Emit the message.
        self.emit('signalEndCall', argum);
    });

    // Signalling event.
    this.webrtcadapter.on('signallingEventTypingMessage', function (text, signalling, arg) {
        
        // Get the contact.
        var contact = self.createContact(arg.contactUniqueID, arg.contactApplicationID);
        var argum = {
            contact: contact,
            typing: arg.typing,
            text: text
        };

        // Emit the message.
        self.emit('signalTyping', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventICEStateChange', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            state: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactICEStateChange', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventRemoveStream', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            remove: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactRemoveStream', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventAddStream', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            add: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactAddStream', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventAddTrack', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            add: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactAddStream', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelReceivedSize', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            size: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactReceiveSize', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelReceiveComplete', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            buffer: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactReceiveComplete', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelOpen', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            open: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactReceiveOpen', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelClose', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            close: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactReceiveClose', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelError', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            error: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactReceiveError', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelSentSize', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            size: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactSentSize', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventDataChannelSentComplete', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            buffer: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactSentComplete', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventClose', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            close: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactClose', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactEventSessionError', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            session: arg,
            text: text
        };

        // Emit the message.
        self.emit('contactSessionError', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactRecordingData', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            data: arg,
            text: text
        };

        // Emit the message.
        self.emit('peerRecordingData', argum);
    });

    // Contact event.
    this.webrtcadapter.on('peerContactRecordingStopped', function (text, contact, arg) {
        
        var argum = {
            contact: contact,
            evt: arg,
            text: text
        };

        // Emit the message.
        self.emit('peerRecordingStopped', argum);
    });

    // Adapter event.
    this.on('adapterRecordingData', function (text, adapter, arg) {
        
        var argum = {
            data: arg,
            text: text
        };

        // Emit the message.
        self.emit('recordingData', argum);
    });

    // Adapter event.
    this.on('adapterRecordingStopped', function (text, adapter, arg) {
        
        var argum = {
            evt: arg,
            text: text
        };

        // Emit the message.
        self.emit('recordingStopped', argum);
    });
}

/**
 * WebRTC prototype constructor.
 */
WebRTC.prototype = Object.create(WildEmitter.prototype, {
    constructor: {
        value: WebRTC
    }
});

/**
 * Create a new contact if it does not exist, else return existing contact.
 * 
 * @param {string}      contactUniqueID        The contact unique id.
 * @param {string}      contactApplicationID   The contact application id.
 * 
 * @return {ContactPeer} Returns the contact.
 */
WebRTC.prototype.createContact = function (contactUniqueID, contactApplicationID) {

    // Get the contact.
    var contact = this.webrtcadapter.getContactPeer(contactUniqueID, contactApplicationID, false);
    if (contact[0]) {
        // Return the contact.
        return contact[0];
    }
    else {
        // Options.
        var options = { 
            uniqueID: contactUniqueID,
            applicationID: contactApplicationID,
            isData: false
        };

        // Create a new contact.
        contact = this.webrtcadapter.createContactPeer(options);
        return contact;
    }
};

/**
 * Create a new data contact if it does not exist, else return existing contact.
 * 
 * @param {string}      contactUniqueID        The contact unique id.
 * @param {string}      contactApplicationID   The contact application id.
 * 
 * @return {ContactPeer} Returns the contact.
 */
WebRTC.prototype.createContactData = function (contactUniqueID, contactApplicationID) {

    // Get the contact.
    var contact = this.webrtcadapter.getContactPeer(contactUniqueID, contactApplicationID, true);
    if (contact[0]) {
        // Return the contact.
        return contact[0];
    }
    else {
        // Options.
        var options = { 
            uniqueID: contactUniqueID,
            applicationID: contactApplicationID,
            isData: true
        };

        // Create a new contact.
        contact = this.webrtcadapter.createContactPeer(options);
        return contact;
    }
};

/**
 * Remove the contact if it exists.
 * 
 * @param {string}      contactUniqueID        The contact unique id.
 * @param {string}      contactApplicationID   The contact application id.
 */
WebRTC.prototype.removeContact = function (contactUniqueID, contactApplicationID) {

    // Get the contact.
    var contact = this.webrtcadapter.getContactPeer(contactUniqueID, contactApplicationID, false);
    if (contact[0]) {

        // Remove contact.
        this.webrtcadapter.removeContactPeer(contactUniqueID, contactApplicationID, false);
    }
};

/**
 * Remove the data contact if it exists.
 * 
 * @param {string}      contactUniqueID        The contact unique id.
 * @param {string}      contactApplicationID   The contact application id.
 */
WebRTC.prototype.removeContactData = function (contactUniqueID, contactApplicationID) {

    // Get the contact.
    var contact = this.webrtcadapter.getContactPeer(contactUniqueID, contactApplicationID, true);
    if (contact[0]) {

        // Remove contact.
        this.webrtcadapter.removeContactPeer(contactUniqueID, contactApplicationID, true);
    }
};

/**
 * Is the contact in the contact list.
 * 
 * @param {string}  uniqueID        The contact unique id.
 * @param {string}  applicationID   The contact application id.
 * 
 * @return {boolean} True if the contact is in the list; else false.
 */
WebRTC.prototype.isContactPeer = function (contactUniqueID, contactApplicationID) {

    // Get the contact.
    var contact = this.webrtcadapter.isContactPeer(contactUniqueID, contactApplicationID);
    if (contact[0]) {
        // Found one.
        return true;
    }
    else {
        return false;
    }
};

/**
 * Close the webRTC interface.
 */
WebRTC.prototype.close = function () {

    if (this.closed) return;
    this.closed = true;
    
    try {
        // Close the interface.
        this.webrtcadapter.close();
    }
    catch (e) {
        // Log the error.
        this.logger.error("Error closing the WebRTC interface: " + e);
    }
};

/**
 * Change client settings.
 * 
 * @param {string}      uniqueID        The contact unique id.
 * @param {string}      applicationID   The contact application id.
 * @param {boolean}     available       True if this client is avaliable for contact; else false.
 * @param {boolean}     broadcast       True if this client allows the unique id to be broadcast; else false.
 * @param {boolean}     broadcastAppID  True if this client allows the application id to be broadcast; else false.
 * @param {string}      accessToken     The access token.
 */
WebRTC.prototype.changeClientSettings = function (uniqueID, applicationID, available, broadcast, broadcastAppID, accessToken) {

    // Change client settings
    this.webrtcadapter.changeClientSettings(uniqueID, applicationID, available, broadcast, broadcastAppID, accessToken);
};

/**
 * Create the local audio and video stream.
 *
 * @param {boolean}     audio   True to enable audio in local stream; else false.
 * @param {boolean}     video   True to enable video in local stream; else false.
 */
WebRTC.prototype.createStream = function (audio, video) {

    // Create stream.
    this.webrtcadapter.createStream(audio, video);
}

/**
 * Create the local media stream.
 * 
 * @param {string}      audioSource   The audio source.
 * @param {string}      videoSource   The video source.
 */
WebRTC.prototype.createStreamSource = function (audioSource, videoSource) {

    // Create the constraint.
    var constraints = {
        audio: {deviceId: audioSource ? {exact: audioSource} : undefined},
        video: {deviceId: videoSource ? {exact: videoSource} : undefined}
    };

    // Create stream.
    this.webrtcadapter.createStreamEx(constraints);
}

/**
 * Create a local capture media, screen or application window (Note only for Firefox).
 *
 * @param {string}     captureMediaSource   The capture media source ('screen' or 'window').
 */
WebRTC.prototype.createStreamCapture = function (captureMediaSource) {

    // Create stream.
    this.webrtcadapter.createStreamCapture(captureMediaSource);
}

/**
 * Create the local media stream.
 *
 * @param {string}     constraints   The media constraints.
 * @link  https://w3c.github.io/mediacapture-main/getusermedia.html#media-track-constraints
 * @example 
 *      qvga =  video: {width: {exact: 320}, height: {exact: 240}}
 *      vga =   video: {width: {exact: 640}, height: {exact: 480}}
 *      hd =    video: {width: {exact: 1280}, height: {exact: 720}}
 *      fullHd =video: {width: {exact: 1920}, height: {exact: 1080}}
 *      fourK = video: {width: {exact: 4096}, height: {exact: 2160}}
 * 
 *              audio: {deviceId: audioSource ? {exact: audioSource} : undefined}
 *              video: {deviceId: videoSource ? {exact: videoSource} : undefined}
 */
WebRTC.prototype.createStreamEx = function (constraints) {

    // Create stream.
    this.webrtcadapter.createStreamEx(constraints);
}

/**
 * Create the local media stream from the display media selection.
 *
 * @param {string}     constraints   The media constraints.
 * @link  https://w3c.github.io/mediacapture-main/getusermedia.html#media-track-constraints
 * @example 
 *      qvga =  video: {width: {exact: 320}, height: {exact: 240}}
 *      vga =   video: {width: {exact: 640}, height: {exact: 480}}
 *      hd =    video: {width: {exact: 1280}, height: {exact: 720}}
 *      fullHd =video: {width: {exact: 1920}, height: {exact: 1080}}
 *      fourK = video: {width: {exact: 4096}, height: {exact: 2160}}
 * 
 *              audio: {deviceId: audioSource ? {exact: audioSource} : undefined}
 *              video: {deviceId: videoSource ? {exact: videoSource} : undefined}
 */
WebRTC.prototype.createStreamDisplay = function (constraints) {

    // Create stream.
    this.webrtcadapter.createStreamDisplay(constraints);
}

/**
 * Set the local video element.
 * 
 * @param {object}      videoElement   The local video element.
 */
WebRTC.prototype.setLocalVideoElement = function (videoElement) {

    // Assign the video element.
    this.webrtcadapter.setLocalVideoElement(videoElement);
};

/**
 * Set the local stream to the video element.
 * 
 * @param {object}      videoElement   The local video element.
 * 
 * @return {boolean}    True if the stream has been added; else false.
 */
WebRTC.prototype.setLocalStreamToVideoElement = function (videoElement) {

    // Assign the video element.
    return this.webrtcadapter.setLocalStreamToVideoElement(videoElement);
};

/**
 * Get all audio input sources.
 * 
 * @param {object}     callback   The callback function.
 */
WebRTC.prototype.getAudioInputSources = function (callback) {

    // Get all devices
    var deviceIndex = 1;
    var sources = [];

    // Get the device list.
    this.webrtcadapter.getAudioInputDevices(function(devices) { 
        // For each device.
        devices.forEach(function (device) {

            var info = { 
                deviceID: device.deviceId,
                deviceText: device.label || 'microphone ' + deviceIndex
            };

            // Add to source.
            sources.push(info);
            deviceIndex++;
        });

        // Send callback.
        callback(sources);
    });
}

/**
 * Get all audio output sources.
 * 
 * @param {object}     callback   The callback function.
 */
WebRTC.prototype.getAudioOutputSources = function (callback) {

    // Get all devices
    var deviceIndex = 1;
    var sources = [];

    // Get the device list.
    this.webrtcadapter.getAudioOutputDevices(function(devices) { 
        // For each device.
        devices.forEach(function (device) {

            var info = { 
                deviceID: device.deviceId,
                deviceText: device.label || 'speaker ' + deviceIndex
            };

            // Add to source.
            sources.push(info);
            deviceIndex++;
        });

        // Send callback.
        callback(sources);
    });
}

/**
 * Get all video input sources.
 * 
 * @param {object}     callback   The callback function.
 */
WebRTC.prototype.getVideoInputSources = function (callback) {

    // Get all devices
    var deviceIndex = 1;
    var sources = [];

    // Get the device list.
    this.webrtcadapter.getVideoInputDevices(function(devices) { 
        // For each device.
        devices.forEach(function (device) {

            var info = { 
                deviceID: device.deviceId,
                deviceText: device.label || 'camera ' + deviceIndex
            };

            // Add to source.
            sources.push(info);
            deviceIndex++;
        });

        // Send callback.
        callback(sources);
    });
}

/**
 * Attach audio output device to video element using device/sink ID.
 * 
 * @param {object}      videoElement    The video element.
 * @param {string}      deviceID        The source device id.
 */
WebRTC.prototype.attachSinkIdVideoElement = function (videoElement, deviceID) {

    // If no sink id applied.
    if (typeof videoElement.sinkId !== 'undefined') {

        // Set the device ID.
        videoElement.setSinkId(deviceID)
        .then(function() {
            // Success.
        })
        .catch(function(e) {
    
            // Log the error.
            this.logger.error("Error assigning device ID: " + e);
        });
    } 
    else {
        this.logger.error("Browser does not support output device selection.");
    }
};

/**
 * Take a picture of what is in the video element,
 * using the canvas element as the base context.
 * 
 * @param {object}      videoElement    The video element (get the width and height of the video).
 * @param {object}      canvasElement   The canvas element (set the width and height of the canvas).
 * 
 * @return {object}     The picture data; else null.
 */
WebRTC.prototype.takePicture = function (videoElement, canvasElement) {

    var data = null;
    var width = videoElement.videoWidth;
    var height = videoElement.videoHeight;

    // Get the canvas contaxt.
    var context = canvasElement.getContext('2d');
    canvasElement.width = width;
    canvasElement.height = height;

    // Draw the picture on the cavas.
    context.drawImage(videoElement, 0, 0, width, height);

    // Get the data.
    data = canvasElement.toDataURL('image/png');

    // Return the picture data.
    return data
};

/**
 * Close the local stream.
 */
WebRTC.prototype.closeStream = function () {
    
    // Close stream.
    this.webrtcadapter.closeStream();
};

// Export the prototype.
module.exports = WebRTC;