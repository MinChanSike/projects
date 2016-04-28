﻿namespace Nequeo.VoIP.PjSip.UI
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxAudioDevice = new System.Windows.Forms.GroupBox();
            this.comboBoxAudioPlaybackDevice = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioCaptureDevice = new System.Windows.Forms.ComboBox();
            this.labelAudioPlaybackDevice = new System.Windows.Forms.Label();
            this.labelAudioCaptureDevice = new System.Windows.Forms.Label();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.labelMessageBankWaitSec = new System.Windows.Forms.Label();
            this.textBoxMessageBankWait = new System.Windows.Forms.TextBox();
            this.labelMessageBankWait = new System.Windows.Forms.Label();
            this.labelAutoAnswerWaitSec = new System.Windows.Forms.Label();
            this.textBoxAutoAnswerWait = new System.Windows.Forms.TextBox();
            this.checkBoxAutoAnswer = new System.Windows.Forms.CheckBox();
            this.checkBoxSrtpSecureSignaling = new System.Windows.Forms.CheckBox();
            this.checkBoxUseSrtp = new System.Windows.Forms.CheckBox();
            this.checkBoxUseIPv6 = new System.Windows.Forms.CheckBox();
            this.checkBoxIceEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxNoIceRtcp = new System.Windows.Forms.CheckBox();
            this.checkBoxRegisterOnAdd = new System.Windows.Forms.CheckBox();
            this.checkBoxDropCallsOnFail = new System.Windows.Forms.CheckBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.checkBoxIsDefault = new System.Windows.Forms.CheckBox();
            this.textBoxSipPort = new System.Windows.Forms.TextBox();
            this.labelSipPort = new System.Windows.Forms.Label();
            this.groupBoxMessageWaitingIndication = new System.Windows.Forms.GroupBox();
            this.labelMwiExpirationSec = new System.Windows.Forms.Label();
            this.textBoxMwiExpiration = new System.Windows.Forms.TextBox();
            this.labelMwiExpiration = new System.Windows.Forms.Label();
            this.checkBoxMessageWaitingIndicationEnabled = new System.Windows.Forms.CheckBox();
            this.groupBoxMediaTransport = new System.Windows.Forms.GroupBox();
            this.textBoxMediaTransportPortRange = new System.Windows.Forms.TextBox();
            this.labelMediaTransportPortRange = new System.Windows.Forms.Label();
            this.textBoxMediaTransportPort = new System.Windows.Forms.TextBox();
            this.labelMediaTransportPort = new System.Windows.Forms.Label();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.labelTimeUnregisterWaitSec = new System.Windows.Forms.Label();
            this.labelTimeTimeoutSec = new System.Windows.Forms.Label();
            this.labelTimeUnregisterWait = new System.Windows.Forms.Label();
            this.textBoxTimeUnregisterWait = new System.Windows.Forms.TextBox();
            this.textBoxTimeTimeout = new System.Windows.Forms.TextBox();
            this.labelTimeTimeout = new System.Windows.Forms.Label();
            this.labelDelayBeforeRefreshSec = new System.Windows.Forms.Label();
            this.labelTimeFirstRetryIntervalSec = new System.Windows.Forms.Label();
            this.labelTimeRetryIntervalSec = new System.Windows.Forms.Label();
            this.labelTimeDelayBeforeRefresh = new System.Windows.Forms.Label();
            this.textBoxTimeDelayBeforeRefresh = new System.Windows.Forms.TextBox();
            this.textBoxTimeFirstRetryInterval = new System.Windows.Forms.TextBox();
            this.textBoxTimeRetryInterval = new System.Windows.Forms.TextBox();
            this.labelTimeFirstRetryInterval = new System.Windows.Forms.Label();
            this.labelTimeRetryInterval = new System.Windows.Forms.Label();
            this.groupBoxTimer = new System.Windows.Forms.GroupBox();
            this.labelTimerSessExpiresSec = new System.Windows.Forms.Label();
            this.textBoxTimerSessExpires = new System.Windows.Forms.TextBox();
            this.labelTimerSessExpires = new System.Windows.Forms.Label();
            this.labelTimerMinSESec = new System.Windows.Forms.Label();
            this.textBoxTimerMinSE = new System.Windows.Forms.TextBox();
            this.labelTimerMinSE = new System.Windows.Forms.Label();
            this.groupBoxRecording = new System.Windows.Forms.GroupBox();
            this.buttonAudioRecordOutCall = new System.Windows.Forms.Button();
            this.buttonAudioRecordInCall = new System.Windows.Forms.Button();
            this.checkBoxAudioRecordOutCall = new System.Windows.Forms.CheckBox();
            this.checkBoxAudioRecordInCall = new System.Windows.Forms.CheckBox();
            this.textBoxAudioRecordInCall = new System.Windows.Forms.TextBox();
            this.textBoxAudioRecordOutCall = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.buttonContactFilePath = new System.Windows.Forms.Button();
            this.labelContactFilePath = new System.Windows.Forms.Label();
            this.textBoxContactFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCredentials = new System.Windows.Forms.GroupBox();
            this.textBoxCredentialsPassword = new System.Windows.Forms.TextBox();
            this.textBoxCredentialsUsername = new System.Windows.Forms.TextBox();
            this.labelCredentialsPassword = new System.Windows.Forms.Label();
            this.labelCredentialsUsername = new System.Windows.Forms.Label();
            this.textBoxCredentialsSipHost = new System.Windows.Forms.TextBox();
            this.textBoxCredentialsAccountName = new System.Windows.Forms.TextBox();
            this.labelCredentialsSipHost = new System.Windows.Forms.Label();
            this.labelCredentialsName = new System.Windows.Forms.Label();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.groupBoxPublish = new System.Windows.Forms.GroupBox();
            this.labelPublishShutdownWaitMsec = new System.Windows.Forms.Label();
            this.textBoxPublishShutdownWait = new System.Windows.Forms.TextBox();
            this.labelPublishShutdownWait = new System.Windows.Forms.Label();
            this.checkBoxPublishQueue = new System.Windows.Forms.CheckBox();
            this.checkBoxPublishEnabled = new System.Windows.Forms.CheckBox();
            this.tabPageMedia = new System.Windows.Forms.TabPage();
            this.groupBoxSounds = new System.Windows.Forms.GroupBox();
            this.buttonSoundsAutoAnswer = new System.Windows.Forms.Button();
            this.textBoxSoundsAutoAnswer = new System.Windows.Forms.TextBox();
            this.labelSoundsAutoAnswer = new System.Windows.Forms.Label();
            this.labelSoundsAudioDevice = new System.Windows.Forms.Label();
            this.comboBoxSoundsAudioDevice = new System.Windows.Forms.ComboBox();
            this.buttonSoundsIMPath = new System.Windows.Forms.Button();
            this.labelSoundsIMPath = new System.Windows.Forms.Label();
            this.textBoxSoundsIMPath = new System.Windows.Forms.TextBox();
            this.labelSoundsRingPath = new System.Windows.Forms.Label();
            this.buttonSoundsRingPath = new System.Windows.Forms.Button();
            this.textBoxSoundsRingPath = new System.Windows.Forms.TextBox();
            this.tabPageCodec = new System.Windows.Forms.TabPage();
            this.groupBoxVideoCodec = new System.Windows.Forms.GroupBox();
            this.checkedListBoxVideoCodec = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStripVideoCodecPriority = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemVideoChangePriority = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAudioCodec = new System.Windows.Forms.GroupBox();
            this.checkedListBoxAudioCodec = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStripCodecPriority = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemChangePriority = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFeatureTransferCall = new System.Windows.Forms.GroupBox();
            this.labelRedirectCallToNumber = new System.Windows.Forms.Label();
            this.labelRedirectCallTimeSec = new System.Windows.Forms.Label();
            this.textBoxRedirectCallTime = new System.Windows.Forms.TextBox();
            this.labelRedirectCallTime = new System.Windows.Forms.Label();
            this.textBoxRedirectCallText = new System.Windows.Forms.TextBox();
            this.checkBoxRedirectCallEnabled = new System.Windows.Forms.CheckBox();
            this.groupBoxVideoDevice = new System.Windows.Forms.GroupBox();
            this.labelVideoBandwidthRateBits = new System.Windows.Forms.Label();
            this.textBoxVideoBandwidthRate = new System.Windows.Forms.TextBox();
            this.labelVideoBandwidthRate = new System.Windows.Forms.Label();
            this.checkBoxVideo = new System.Windows.Forms.CheckBox();
            this.comboBoxVideoDevicePlayback = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoDeviceCapture = new System.Windows.Forms.ComboBox();
            this.labelVideoDevicePlayback = new System.Windows.Forms.Label();
            this.labelVideoDeviceCapture = new System.Windows.Forms.Label();
            this.groupBoxAudioDevice.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxMessageWaitingIndication.SuspendLayout();
            this.groupBoxMediaTransport.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxTimer.SuspendLayout();
            this.groupBoxRecording.SuspendLayout();
            this.groupBoxContacts.SuspendLayout();
            this.groupBoxCredentials.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.groupBoxPublish.SuspendLayout();
            this.tabPageMedia.SuspendLayout();
            this.groupBoxSounds.SuspendLayout();
            this.tabPageCodec.SuspendLayout();
            this.groupBoxVideoCodec.SuspendLayout();
            this.contextMenuStripVideoCodecPriority.SuspendLayout();
            this.groupBoxAudioCodec.SuspendLayout();
            this.contextMenuStripCodecPriority.SuspendLayout();
            this.groupBoxFeatureTransferCall.SuspendLayout();
            this.groupBoxVideoDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAudioDevice
            // 
            this.groupBoxAudioDevice.Controls.Add(this.comboBoxAudioPlaybackDevice);
            this.groupBoxAudioDevice.Controls.Add(this.comboBoxAudioCaptureDevice);
            this.groupBoxAudioDevice.Controls.Add(this.labelAudioPlaybackDevice);
            this.groupBoxAudioDevice.Controls.Add(this.labelAudioCaptureDevice);
            this.groupBoxAudioDevice.Location = new System.Drawing.Point(6, 88);
            this.groupBoxAudioDevice.Name = "groupBoxAudioDevice";
            this.groupBoxAudioDevice.Size = new System.Drawing.Size(475, 84);
            this.groupBoxAudioDevice.TabIndex = 0;
            this.groupBoxAudioDevice.TabStop = false;
            this.groupBoxAudioDevice.Text = "Audio Device";
            // 
            // comboBoxAudioPlaybackDevice
            // 
            this.comboBoxAudioPlaybackDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioPlaybackDevice.FormattingEnabled = true;
            this.comboBoxAudioPlaybackDevice.Location = new System.Drawing.Point(78, 46);
            this.comboBoxAudioPlaybackDevice.Name = "comboBoxAudioPlaybackDevice";
            this.comboBoxAudioPlaybackDevice.Size = new System.Drawing.Size(381, 21);
            this.comboBoxAudioPlaybackDevice.TabIndex = 5;
            this.comboBoxAudioPlaybackDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioPlaybackDevice_SelectedIndexChanged);
            // 
            // comboBoxAudioCaptureDevice
            // 
            this.comboBoxAudioCaptureDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioCaptureDevice.FormattingEnabled = true;
            this.comboBoxAudioCaptureDevice.Location = new System.Drawing.Point(78, 19);
            this.comboBoxAudioCaptureDevice.Name = "comboBoxAudioCaptureDevice";
            this.comboBoxAudioCaptureDevice.Size = new System.Drawing.Size(381, 21);
            this.comboBoxAudioCaptureDevice.TabIndex = 4;
            this.comboBoxAudioCaptureDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioCaptureDevice_SelectedIndexChanged);
            // 
            // labelAudioPlaybackDevice
            // 
            this.labelAudioPlaybackDevice.AutoSize = true;
            this.labelAudioPlaybackDevice.Location = new System.Drawing.Point(15, 49);
            this.labelAudioPlaybackDevice.Name = "labelAudioPlaybackDevice";
            this.labelAudioPlaybackDevice.Size = new System.Drawing.Size(57, 13);
            this.labelAudioPlaybackDevice.TabIndex = 1;
            this.labelAudioPlaybackDevice.Text = "Playback :";
            // 
            // labelAudioCaptureDevice
            // 
            this.labelAudioCaptureDevice.AutoSize = true;
            this.labelAudioCaptureDevice.Location = new System.Drawing.Point(15, 22);
            this.labelAudioCaptureDevice.Name = "labelAudioCaptureDevice";
            this.labelAudioCaptureDevice.Size = new System.Drawing.Size(50, 13);
            this.labelAudioCaptureDevice.TabIndex = 0;
            this.labelAudioCaptureDevice.Text = "Capture :";
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.labelMessageBankWaitSec);
            this.groupBoxAccount.Controls.Add(this.textBoxMessageBankWait);
            this.groupBoxAccount.Controls.Add(this.labelMessageBankWait);
            this.groupBoxAccount.Controls.Add(this.labelAutoAnswerWaitSec);
            this.groupBoxAccount.Controls.Add(this.textBoxAutoAnswerWait);
            this.groupBoxAccount.Controls.Add(this.checkBoxAutoAnswer);
            this.groupBoxAccount.Controls.Add(this.checkBoxSrtpSecureSignaling);
            this.groupBoxAccount.Controls.Add(this.checkBoxUseSrtp);
            this.groupBoxAccount.Controls.Add(this.checkBoxUseIPv6);
            this.groupBoxAccount.Controls.Add(this.checkBoxIceEnabled);
            this.groupBoxAccount.Controls.Add(this.checkBoxNoIceRtcp);
            this.groupBoxAccount.Controls.Add(this.checkBoxRegisterOnAdd);
            this.groupBoxAccount.Controls.Add(this.checkBoxDropCallsOnFail);
            this.groupBoxAccount.Controls.Add(this.textBoxPriority);
            this.groupBoxAccount.Controls.Add(this.labelPriority);
            this.groupBoxAccount.Controls.Add(this.checkBoxIsDefault);
            this.groupBoxAccount.Controls.Add(this.textBoxSipPort);
            this.groupBoxAccount.Controls.Add(this.labelSipPort);
            this.groupBoxAccount.Location = new System.Drawing.Point(6, 6);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(182, 315);
            this.groupBoxAccount.TabIndex = 2;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account";
            // 
            // labelMessageBankWaitSec
            // 
            this.labelMessageBankWaitSec.AutoSize = true;
            this.labelMessageBankWaitSec.Location = new System.Drawing.Point(158, 286);
            this.labelMessageBankWaitSec.Name = "labelMessageBankWaitSec";
            this.labelMessageBankWaitSec.Size = new System.Drawing.Size(18, 13);
            this.labelMessageBankWaitSec.TabIndex = 18;
            this.labelMessageBankWaitSec.Text = "(s)";
            // 
            // textBoxMessageBankWait
            // 
            this.textBoxMessageBankWait.Location = new System.Drawing.Point(110, 283);
            this.textBoxMessageBankWait.Name = "textBoxMessageBankWait";
            this.textBoxMessageBankWait.Size = new System.Drawing.Size(42, 20);
            this.textBoxMessageBankWait.TabIndex = 26;
            this.textBoxMessageBankWait.TextChanged += new System.EventHandler(this.textBoxMessageBankWait_TextChanged);
            // 
            // labelMessageBankWait
            // 
            this.labelMessageBankWait.AutoSize = true;
            this.labelMessageBankWait.Location = new System.Drawing.Point(15, 286);
            this.labelMessageBankWait.Name = "labelMessageBankWait";
            this.labelMessageBankWait.Size = new System.Drawing.Size(84, 13);
            this.labelMessageBankWait.TabIndex = 16;
            this.labelMessageBankWait.Text = "Message Bank :";
            // 
            // labelAutoAnswerWaitSec
            // 
            this.labelAutoAnswerWaitSec.AutoSize = true;
            this.labelAutoAnswerWaitSec.Location = new System.Drawing.Point(158, 260);
            this.labelAutoAnswerWaitSec.Name = "labelAutoAnswerWaitSec";
            this.labelAutoAnswerWaitSec.Size = new System.Drawing.Size(18, 13);
            this.labelAutoAnswerWaitSec.TabIndex = 15;
            this.labelAutoAnswerWaitSec.Text = "(s)";
            // 
            // textBoxAutoAnswerWait
            // 
            this.textBoxAutoAnswerWait.Location = new System.Drawing.Point(110, 257);
            this.textBoxAutoAnswerWait.Name = "textBoxAutoAnswerWait";
            this.textBoxAutoAnswerWait.Size = new System.Drawing.Size(42, 20);
            this.textBoxAutoAnswerWait.TabIndex = 25;
            this.textBoxAutoAnswerWait.TextChanged += new System.EventHandler(this.textBoxAutoAnswerWait_TextChanged);
            // 
            // checkBoxAutoAnswer
            // 
            this.checkBoxAutoAnswer.AutoSize = true;
            this.checkBoxAutoAnswer.Location = new System.Drawing.Point(18, 259);
            this.checkBoxAutoAnswer.Name = "checkBoxAutoAnswer";
            this.checkBoxAutoAnswer.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAutoAnswer.TabIndex = 24;
            this.checkBoxAutoAnswer.Text = "Auto Answer";
            this.checkBoxAutoAnswer.UseVisualStyleBackColor = true;
            this.checkBoxAutoAnswer.CheckedChanged += new System.EventHandler(this.checkBoxAutoAnswer_CheckedChanged);
            // 
            // checkBoxSrtpSecureSignaling
            // 
            this.checkBoxSrtpSecureSignaling.AutoSize = true;
            this.checkBoxSrtpSecureSignaling.Location = new System.Drawing.Point(18, 140);
            this.checkBoxSrtpSecureSignaling.Name = "checkBoxSrtpSecureSignaling";
            this.checkBoxSrtpSecureSignaling.Size = new System.Drawing.Size(128, 17);
            this.checkBoxSrtpSecureSignaling.TabIndex = 19;
            this.checkBoxSrtpSecureSignaling.Text = "Srtp Secure Signaling";
            this.checkBoxSrtpSecureSignaling.ThreeState = true;
            this.checkBoxSrtpSecureSignaling.UseVisualStyleBackColor = true;
            this.checkBoxSrtpSecureSignaling.CheckedChanged += new System.EventHandler(this.checkBoxSrtpSecureSignaling_CheckedChanged);
            // 
            // checkBoxUseSrtp
            // 
            this.checkBoxUseSrtp.AutoSize = true;
            this.checkBoxUseSrtp.Location = new System.Drawing.Point(18, 117);
            this.checkBoxUseSrtp.Name = "checkBoxUseSrtp";
            this.checkBoxUseSrtp.Size = new System.Drawing.Size(67, 17);
            this.checkBoxUseSrtp.TabIndex = 18;
            this.checkBoxUseSrtp.Text = "Use Srtp";
            this.checkBoxUseSrtp.ThreeState = true;
            this.checkBoxUseSrtp.UseVisualStyleBackColor = true;
            this.checkBoxUseSrtp.CheckedChanged += new System.EventHandler(this.checkBoxUseSrtp_CheckedChanged);
            // 
            // checkBoxUseIPv6
            // 
            this.checkBoxUseIPv6.AutoSize = true;
            this.checkBoxUseIPv6.Location = new System.Drawing.Point(18, 94);
            this.checkBoxUseIPv6.Name = "checkBoxUseIPv6";
            this.checkBoxUseIPv6.Size = new System.Drawing.Size(70, 17);
            this.checkBoxUseIPv6.TabIndex = 17;
            this.checkBoxUseIPv6.Text = "Use IPv6";
            this.checkBoxUseIPv6.ThreeState = true;
            this.checkBoxUseIPv6.UseVisualStyleBackColor = true;
            this.checkBoxUseIPv6.CheckedChanged += new System.EventHandler(this.checkBoxUseIPv6_CheckedChanged);
            // 
            // checkBoxIceEnabled
            // 
            this.checkBoxIceEnabled.AutoSize = true;
            this.checkBoxIceEnabled.Location = new System.Drawing.Point(18, 236);
            this.checkBoxIceEnabled.Name = "checkBoxIceEnabled";
            this.checkBoxIceEnabled.Size = new System.Drawing.Size(83, 17);
            this.checkBoxIceEnabled.TabIndex = 23;
            this.checkBoxIceEnabled.Text = "Ice Enabled";
            this.checkBoxIceEnabled.UseVisualStyleBackColor = true;
            this.checkBoxIceEnabled.CheckedChanged += new System.EventHandler(this.checkBoxIceEnabled_CheckedChanged);
            // 
            // checkBoxNoIceRtcp
            // 
            this.checkBoxNoIceRtcp.AutoSize = true;
            this.checkBoxNoIceRtcp.Location = new System.Drawing.Point(18, 212);
            this.checkBoxNoIceRtcp.Name = "checkBoxNoIceRtcp";
            this.checkBoxNoIceRtcp.Size = new System.Drawing.Size(84, 17);
            this.checkBoxNoIceRtcp.TabIndex = 22;
            this.checkBoxNoIceRtcp.Text = "No Ice Rtcp";
            this.checkBoxNoIceRtcp.UseVisualStyleBackColor = true;
            this.checkBoxNoIceRtcp.CheckedChanged += new System.EventHandler(this.checkBoxNoIceRtcp_CheckedChanged);
            // 
            // checkBoxRegisterOnAdd
            // 
            this.checkBoxRegisterOnAdd.AutoSize = true;
            this.checkBoxRegisterOnAdd.Location = new System.Drawing.Point(18, 187);
            this.checkBoxRegisterOnAdd.Name = "checkBoxRegisterOnAdd";
            this.checkBoxRegisterOnAdd.Size = new System.Drawing.Size(104, 17);
            this.checkBoxRegisterOnAdd.TabIndex = 21;
            this.checkBoxRegisterOnAdd.Text = "Register On Add";
            this.checkBoxRegisterOnAdd.UseVisualStyleBackColor = true;
            this.checkBoxRegisterOnAdd.CheckedChanged += new System.EventHandler(this.checkBoxRegisterOnAdd_CheckedChanged);
            // 
            // checkBoxDropCallsOnFail
            // 
            this.checkBoxDropCallsOnFail.AutoSize = true;
            this.checkBoxDropCallsOnFail.Location = new System.Drawing.Point(18, 163);
            this.checkBoxDropCallsOnFail.Name = "checkBoxDropCallsOnFail";
            this.checkBoxDropCallsOnFail.Size = new System.Drawing.Size(110, 17);
            this.checkBoxDropCallsOnFail.TabIndex = 20;
            this.checkBoxDropCallsOnFail.Text = "Drop Calls On Fail";
            this.checkBoxDropCallsOnFail.UseVisualStyleBackColor = true;
            this.checkBoxDropCallsOnFail.CheckedChanged += new System.EventHandler(this.checkBoxDropCallsOnFail_CheckedChanged);
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(65, 68);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(60, 20);
            this.textBoxPriority.TabIndex = 16;
            this.textBoxPriority.TextChanged += new System.EventHandler(this.textBoxPriority_TextChanged);
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(15, 71);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(44, 13);
            this.labelPriority.TabIndex = 4;
            this.labelPriority.Text = "Priority :";
            // 
            // checkBoxIsDefault
            // 
            this.checkBoxIsDefault.AutoSize = true;
            this.checkBoxIsDefault.Location = new System.Drawing.Point(18, 45);
            this.checkBoxIsDefault.Name = "checkBoxIsDefault";
            this.checkBoxIsDefault.Size = new System.Drawing.Size(71, 17);
            this.checkBoxIsDefault.TabIndex = 15;
            this.checkBoxIsDefault.Text = "Is Default";
            this.checkBoxIsDefault.UseVisualStyleBackColor = true;
            this.checkBoxIsDefault.CheckedChanged += new System.EventHandler(this.checkBoxIsDefault_CheckedChanged);
            // 
            // textBoxSipPort
            // 
            this.textBoxSipPort.Location = new System.Drawing.Point(65, 19);
            this.textBoxSipPort.Name = "textBoxSipPort";
            this.textBoxSipPort.Size = new System.Drawing.Size(60, 20);
            this.textBoxSipPort.TabIndex = 14;
            this.textBoxSipPort.TextChanged += new System.EventHandler(this.textBoxSipPort_TextChanged);
            // 
            // labelSipPort
            // 
            this.labelSipPort.AutoSize = true;
            this.labelSipPort.Location = new System.Drawing.Point(15, 22);
            this.labelSipPort.Name = "labelSipPort";
            this.labelSipPort.Size = new System.Drawing.Size(32, 13);
            this.labelSipPort.TabIndex = 0;
            this.labelSipPort.Text = "Port :";
            // 
            // groupBoxMessageWaitingIndication
            // 
            this.groupBoxMessageWaitingIndication.Controls.Add(this.labelMwiExpirationSec);
            this.groupBoxMessageWaitingIndication.Controls.Add(this.textBoxMwiExpiration);
            this.groupBoxMessageWaitingIndication.Controls.Add(this.labelMwiExpiration);
            this.groupBoxMessageWaitingIndication.Controls.Add(this.checkBoxMessageWaitingIndicationEnabled);
            this.groupBoxMessageWaitingIndication.Location = new System.Drawing.Point(6, 6);
            this.groupBoxMessageWaitingIndication.Name = "groupBoxMessageWaitingIndication";
            this.groupBoxMessageWaitingIndication.Size = new System.Drawing.Size(182, 83);
            this.groupBoxMessageWaitingIndication.TabIndex = 3;
            this.groupBoxMessageWaitingIndication.TabStop = false;
            this.groupBoxMessageWaitingIndication.Text = "Message Waiting Indication";
            // 
            // labelMwiExpirationSec
            // 
            this.labelMwiExpirationSec.AutoSize = true;
            this.labelMwiExpirationSec.Location = new System.Drawing.Point(154, 47);
            this.labelMwiExpirationSec.Name = "labelMwiExpirationSec";
            this.labelMwiExpirationSec.Size = new System.Drawing.Size(18, 13);
            this.labelMwiExpirationSec.TabIndex = 3;
            this.labelMwiExpirationSec.Text = "(s)";
            // 
            // textBoxMwiExpiration
            // 
            this.textBoxMwiExpiration.Location = new System.Drawing.Point(88, 44);
            this.textBoxMwiExpiration.Name = "textBoxMwiExpiration";
            this.textBoxMwiExpiration.Size = new System.Drawing.Size(60, 20);
            this.textBoxMwiExpiration.TabIndex = 38;
            this.textBoxMwiExpiration.TextChanged += new System.EventHandler(this.textBoxMwiExpiration_TextChanged);
            // 
            // labelMwiExpiration
            // 
            this.labelMwiExpiration.AutoSize = true;
            this.labelMwiExpiration.Location = new System.Drawing.Point(15, 47);
            this.labelMwiExpiration.Name = "labelMwiExpiration";
            this.labelMwiExpiration.Size = new System.Drawing.Size(59, 13);
            this.labelMwiExpiration.TabIndex = 1;
            this.labelMwiExpiration.Text = "Expiration :";
            // 
            // checkBoxMessageWaitingIndicationEnabled
            // 
            this.checkBoxMessageWaitingIndicationEnabled.AutoSize = true;
            this.checkBoxMessageWaitingIndicationEnabled.Location = new System.Drawing.Point(18, 22);
            this.checkBoxMessageWaitingIndicationEnabled.Name = "checkBoxMessageWaitingIndicationEnabled";
            this.checkBoxMessageWaitingIndicationEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxMessageWaitingIndicationEnabled.TabIndex = 37;
            this.checkBoxMessageWaitingIndicationEnabled.Text = "Enabled";
            this.checkBoxMessageWaitingIndicationEnabled.UseVisualStyleBackColor = true;
            this.checkBoxMessageWaitingIndicationEnabled.CheckedChanged += new System.EventHandler(this.checkBoxMessageWaitingIndicationEnabled_CheckedChanged);
            // 
            // groupBoxMediaTransport
            // 
            this.groupBoxMediaTransport.Controls.Add(this.textBoxMediaTransportPortRange);
            this.groupBoxMediaTransport.Controls.Add(this.labelMediaTransportPortRange);
            this.groupBoxMediaTransport.Controls.Add(this.textBoxMediaTransportPort);
            this.groupBoxMediaTransport.Controls.Add(this.labelMediaTransportPort);
            this.groupBoxMediaTransport.Location = new System.Drawing.Point(194, 6);
            this.groupBoxMediaTransport.Name = "groupBoxMediaTransport";
            this.groupBoxMediaTransport.Size = new System.Drawing.Size(287, 83);
            this.groupBoxMediaTransport.TabIndex = 4;
            this.groupBoxMediaTransport.TabStop = false;
            this.groupBoxMediaTransport.Text = "Media Transport";
            // 
            // textBoxMediaTransportPortRange
            // 
            this.textBoxMediaTransportPortRange.Location = new System.Drawing.Point(88, 45);
            this.textBoxMediaTransportPortRange.Name = "textBoxMediaTransportPortRange";
            this.textBoxMediaTransportPortRange.Size = new System.Drawing.Size(60, 20);
            this.textBoxMediaTransportPortRange.TabIndex = 40;
            this.textBoxMediaTransportPortRange.TextChanged += new System.EventHandler(this.textBoxMediaTransportPortRange_TextChanged);
            // 
            // labelMediaTransportPortRange
            // 
            this.labelMediaTransportPortRange.AutoSize = true;
            this.labelMediaTransportPortRange.Location = new System.Drawing.Point(15, 48);
            this.labelMediaTransportPortRange.Name = "labelMediaTransportPortRange";
            this.labelMediaTransportPortRange.Size = new System.Drawing.Size(67, 13);
            this.labelMediaTransportPortRange.TabIndex = 2;
            this.labelMediaTransportPortRange.Text = "Port Range :";
            // 
            // textBoxMediaTransportPort
            // 
            this.textBoxMediaTransportPort.Location = new System.Drawing.Point(88, 19);
            this.textBoxMediaTransportPort.Name = "textBoxMediaTransportPort";
            this.textBoxMediaTransportPort.Size = new System.Drawing.Size(60, 20);
            this.textBoxMediaTransportPort.TabIndex = 39;
            this.textBoxMediaTransportPort.TextChanged += new System.EventHandler(this.textBoxMediaTransportPort_TextChanged);
            // 
            // labelMediaTransportPort
            // 
            this.labelMediaTransportPort.AutoSize = true;
            this.labelMediaTransportPort.Location = new System.Drawing.Point(15, 22);
            this.labelMediaTransportPort.Name = "labelMediaTransportPort";
            this.labelMediaTransportPort.Size = new System.Drawing.Size(32, 13);
            this.labelMediaTransportPort.TabIndex = 0;
            this.labelMediaTransportPort.Text = "Port :";
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labelTimeUnregisterWaitSec);
            this.groupBoxTime.Controls.Add(this.labelTimeTimeoutSec);
            this.groupBoxTime.Controls.Add(this.labelTimeUnregisterWait);
            this.groupBoxTime.Controls.Add(this.textBoxTimeUnregisterWait);
            this.groupBoxTime.Controls.Add(this.textBoxTimeTimeout);
            this.groupBoxTime.Controls.Add(this.labelTimeTimeout);
            this.groupBoxTime.Controls.Add(this.labelDelayBeforeRefreshSec);
            this.groupBoxTime.Controls.Add(this.labelTimeFirstRetryIntervalSec);
            this.groupBoxTime.Controls.Add(this.labelTimeRetryIntervalSec);
            this.groupBoxTime.Controls.Add(this.labelTimeDelayBeforeRefresh);
            this.groupBoxTime.Controls.Add(this.textBoxTimeDelayBeforeRefresh);
            this.groupBoxTime.Controls.Add(this.textBoxTimeFirstRetryInterval);
            this.groupBoxTime.Controls.Add(this.textBoxTimeRetryInterval);
            this.groupBoxTime.Controls.Add(this.labelTimeFirstRetryInterval);
            this.groupBoxTime.Controls.Add(this.labelTimeRetryInterval);
            this.groupBoxTime.Location = new System.Drawing.Point(194, 6);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(287, 157);
            this.groupBoxTime.TabIndex = 5;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time";
            // 
            // labelTimeUnregisterWaitSec
            // 
            this.labelTimeUnregisterWaitSec.AutoSize = true;
            this.labelTimeUnregisterWaitSec.Location = new System.Drawing.Point(201, 126);
            this.labelTimeUnregisterWaitSec.Name = "labelTimeUnregisterWaitSec";
            this.labelTimeUnregisterWaitSec.Size = new System.Drawing.Size(18, 13);
            this.labelTimeUnregisterWaitSec.TabIndex = 14;
            this.labelTimeUnregisterWaitSec.Text = "(s)";
            // 
            // labelTimeTimeoutSec
            // 
            this.labelTimeTimeoutSec.AutoSize = true;
            this.labelTimeTimeoutSec.Location = new System.Drawing.Point(201, 100);
            this.labelTimeTimeoutSec.Name = "labelTimeTimeoutSec";
            this.labelTimeTimeoutSec.Size = new System.Drawing.Size(18, 13);
            this.labelTimeTimeoutSec.TabIndex = 13;
            this.labelTimeTimeoutSec.Text = "(s)";
            // 
            // labelTimeUnregisterWait
            // 
            this.labelTimeUnregisterWait.AutoSize = true;
            this.labelTimeUnregisterWait.Location = new System.Drawing.Point(15, 126);
            this.labelTimeUnregisterWait.Name = "labelTimeUnregisterWait";
            this.labelTimeUnregisterWait.Size = new System.Drawing.Size(86, 13);
            this.labelTimeUnregisterWait.TabIndex = 12;
            this.labelTimeUnregisterWait.Text = "Unregister Wait :";
            // 
            // textBoxTimeUnregisterWait
            // 
            this.textBoxTimeUnregisterWait.Location = new System.Drawing.Point(135, 123);
            this.textBoxTimeUnregisterWait.Name = "textBoxTimeUnregisterWait";
            this.textBoxTimeUnregisterWait.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimeUnregisterWait.TabIndex = 31;
            this.textBoxTimeUnregisterWait.TextChanged += new System.EventHandler(this.textBoxTimeUnregisterWait_TextChanged);
            // 
            // textBoxTimeTimeout
            // 
            this.textBoxTimeTimeout.Location = new System.Drawing.Point(135, 97);
            this.textBoxTimeTimeout.Name = "textBoxTimeTimeout";
            this.textBoxTimeTimeout.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimeTimeout.TabIndex = 30;
            this.textBoxTimeTimeout.TextChanged += new System.EventHandler(this.textBoxTimeTimeout_TextChanged);
            // 
            // labelTimeTimeout
            // 
            this.labelTimeTimeout.AutoSize = true;
            this.labelTimeTimeout.Location = new System.Drawing.Point(15, 100);
            this.labelTimeTimeout.Name = "labelTimeTimeout";
            this.labelTimeTimeout.Size = new System.Drawing.Size(51, 13);
            this.labelTimeTimeout.TabIndex = 9;
            this.labelTimeTimeout.Text = "Timeout :";
            // 
            // labelDelayBeforeRefreshSec
            // 
            this.labelDelayBeforeRefreshSec.AutoSize = true;
            this.labelDelayBeforeRefreshSec.Location = new System.Drawing.Point(201, 74);
            this.labelDelayBeforeRefreshSec.Name = "labelDelayBeforeRefreshSec";
            this.labelDelayBeforeRefreshSec.Size = new System.Drawing.Size(18, 13);
            this.labelDelayBeforeRefreshSec.TabIndex = 8;
            this.labelDelayBeforeRefreshSec.Text = "(s)";
            // 
            // labelTimeFirstRetryIntervalSec
            // 
            this.labelTimeFirstRetryIntervalSec.AutoSize = true;
            this.labelTimeFirstRetryIntervalSec.Location = new System.Drawing.Point(201, 48);
            this.labelTimeFirstRetryIntervalSec.Name = "labelTimeFirstRetryIntervalSec";
            this.labelTimeFirstRetryIntervalSec.Size = new System.Drawing.Size(18, 13);
            this.labelTimeFirstRetryIntervalSec.TabIndex = 7;
            this.labelTimeFirstRetryIntervalSec.Text = "(s)";
            // 
            // labelTimeRetryIntervalSec
            // 
            this.labelTimeRetryIntervalSec.AutoSize = true;
            this.labelTimeRetryIntervalSec.Location = new System.Drawing.Point(201, 22);
            this.labelTimeRetryIntervalSec.Name = "labelTimeRetryIntervalSec";
            this.labelTimeRetryIntervalSec.Size = new System.Drawing.Size(18, 13);
            this.labelTimeRetryIntervalSec.TabIndex = 6;
            this.labelTimeRetryIntervalSec.Text = "(s)";
            // 
            // labelTimeDelayBeforeRefresh
            // 
            this.labelTimeDelayBeforeRefresh.AutoSize = true;
            this.labelTimeDelayBeforeRefresh.Location = new System.Drawing.Point(15, 74);
            this.labelTimeDelayBeforeRefresh.Name = "labelTimeDelayBeforeRefresh";
            this.labelTimeDelayBeforeRefresh.Size = new System.Drawing.Size(114, 13);
            this.labelTimeDelayBeforeRefresh.TabIndex = 5;
            this.labelTimeDelayBeforeRefresh.Text = "Delay Before Refresh :";
            // 
            // textBoxTimeDelayBeforeRefresh
            // 
            this.textBoxTimeDelayBeforeRefresh.Location = new System.Drawing.Point(135, 71);
            this.textBoxTimeDelayBeforeRefresh.Name = "textBoxTimeDelayBeforeRefresh";
            this.textBoxTimeDelayBeforeRefresh.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimeDelayBeforeRefresh.TabIndex = 29;
            this.textBoxTimeDelayBeforeRefresh.TextChanged += new System.EventHandler(this.textBoxTimeDelayBeforeRefresh_TextChanged);
            // 
            // textBoxTimeFirstRetryInterval
            // 
            this.textBoxTimeFirstRetryInterval.Location = new System.Drawing.Point(135, 45);
            this.textBoxTimeFirstRetryInterval.Name = "textBoxTimeFirstRetryInterval";
            this.textBoxTimeFirstRetryInterval.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimeFirstRetryInterval.TabIndex = 28;
            this.textBoxTimeFirstRetryInterval.TextChanged += new System.EventHandler(this.textBoxTimeFirstRetryInterval_TextChanged);
            // 
            // textBoxTimeRetryInterval
            // 
            this.textBoxTimeRetryInterval.Location = new System.Drawing.Point(135, 19);
            this.textBoxTimeRetryInterval.Name = "textBoxTimeRetryInterval";
            this.textBoxTimeRetryInterval.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimeRetryInterval.TabIndex = 27;
            this.textBoxTimeRetryInterval.TextChanged += new System.EventHandler(this.textBoxTimeRetryInterval_TextChanged);
            // 
            // labelTimeFirstRetryInterval
            // 
            this.labelTimeFirstRetryInterval.AutoSize = true;
            this.labelTimeFirstRetryInterval.Location = new System.Drawing.Point(15, 48);
            this.labelTimeFirstRetryInterval.Name = "labelTimeFirstRetryInterval";
            this.labelTimeFirstRetryInterval.Size = new System.Drawing.Size(98, 13);
            this.labelTimeFirstRetryInterval.TabIndex = 1;
            this.labelTimeFirstRetryInterval.Text = "First Retry Interval :";
            // 
            // labelTimeRetryInterval
            // 
            this.labelTimeRetryInterval.AutoSize = true;
            this.labelTimeRetryInterval.Location = new System.Drawing.Point(15, 22);
            this.labelTimeRetryInterval.Name = "labelTimeRetryInterval";
            this.labelTimeRetryInterval.Size = new System.Drawing.Size(76, 13);
            this.labelTimeRetryInterval.TabIndex = 0;
            this.labelTimeRetryInterval.Text = "Retry Interval :";
            // 
            // groupBoxTimer
            // 
            this.groupBoxTimer.Controls.Add(this.labelTimerSessExpiresSec);
            this.groupBoxTimer.Controls.Add(this.textBoxTimerSessExpires);
            this.groupBoxTimer.Controls.Add(this.labelTimerSessExpires);
            this.groupBoxTimer.Controls.Add(this.labelTimerMinSESec);
            this.groupBoxTimer.Controls.Add(this.textBoxTimerMinSE);
            this.groupBoxTimer.Controls.Add(this.labelTimerMinSE);
            this.groupBoxTimer.Location = new System.Drawing.Point(194, 169);
            this.groupBoxTimer.Name = "groupBoxTimer";
            this.groupBoxTimer.Size = new System.Drawing.Size(287, 79);
            this.groupBoxTimer.TabIndex = 6;
            this.groupBoxTimer.TabStop = false;
            this.groupBoxTimer.Text = "Timer";
            // 
            // labelTimerSessExpiresSec
            // 
            this.labelTimerSessExpiresSec.AutoSize = true;
            this.labelTimerSessExpiresSec.Location = new System.Drawing.Point(176, 49);
            this.labelTimerSessExpiresSec.Name = "labelTimerSessExpiresSec";
            this.labelTimerSessExpiresSec.Size = new System.Drawing.Size(18, 13);
            this.labelTimerSessExpiresSec.TabIndex = 5;
            this.labelTimerSessExpiresSec.Text = "(s)";
            // 
            // textBoxTimerSessExpires
            // 
            this.textBoxTimerSessExpires.Location = new System.Drawing.Point(115, 45);
            this.textBoxTimerSessExpires.Name = "textBoxTimerSessExpires";
            this.textBoxTimerSessExpires.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimerSessExpires.TabIndex = 33;
            this.textBoxTimerSessExpires.TextChanged += new System.EventHandler(this.textBoxTimerSessExpires_TextChanged);
            // 
            // labelTimerSessExpires
            // 
            this.labelTimerSessExpires.AutoSize = true;
            this.labelTimerSessExpires.Location = new System.Drawing.Point(15, 48);
            this.labelTimerSessExpires.Name = "labelTimerSessExpires";
            this.labelTimerSessExpires.Size = new System.Drawing.Size(87, 13);
            this.labelTimerSessExpires.TabIndex = 3;
            this.labelTimerSessExpires.Text = "Session Expires :";
            // 
            // labelTimerMinSESec
            // 
            this.labelTimerMinSESec.AutoSize = true;
            this.labelTimerMinSESec.Location = new System.Drawing.Point(176, 22);
            this.labelTimerMinSESec.Name = "labelTimerMinSESec";
            this.labelTimerMinSESec.Size = new System.Drawing.Size(18, 13);
            this.labelTimerMinSESec.TabIndex = 2;
            this.labelTimerMinSESec.Text = "(s)";
            // 
            // textBoxTimerMinSE
            // 
            this.textBoxTimerMinSE.Location = new System.Drawing.Point(115, 19);
            this.textBoxTimerMinSE.Name = "textBoxTimerMinSE";
            this.textBoxTimerMinSE.Size = new System.Drawing.Size(60, 20);
            this.textBoxTimerMinSE.TabIndex = 32;
            this.textBoxTimerMinSE.TextChanged += new System.EventHandler(this.textBoxTimerMinSE_TextChanged);
            // 
            // labelTimerMinSE
            // 
            this.labelTimerMinSE.AutoSize = true;
            this.labelTimerMinSE.Location = new System.Drawing.Point(15, 22);
            this.labelTimerMinSE.Name = "labelTimerMinSE";
            this.labelTimerMinSE.Size = new System.Drawing.Size(94, 13);
            this.labelTimerMinSE.TabIndex = 0;
            this.labelTimerMinSE.Text = "Minimum Session :";
            // 
            // groupBoxRecording
            // 
            this.groupBoxRecording.Controls.Add(this.buttonAudioRecordOutCall);
            this.groupBoxRecording.Controls.Add(this.buttonAudioRecordInCall);
            this.groupBoxRecording.Controls.Add(this.checkBoxAudioRecordOutCall);
            this.groupBoxRecording.Controls.Add(this.checkBoxAudioRecordInCall);
            this.groupBoxRecording.Controls.Add(this.textBoxAudioRecordInCall);
            this.groupBoxRecording.Controls.Add(this.textBoxAudioRecordOutCall);
            this.groupBoxRecording.Location = new System.Drawing.Point(6, 178);
            this.groupBoxRecording.Name = "groupBoxRecording";
            this.groupBoxRecording.Size = new System.Drawing.Size(475, 81);
            this.groupBoxRecording.TabIndex = 7;
            this.groupBoxRecording.TabStop = false;
            this.groupBoxRecording.Text = "Audio Recording";
            // 
            // buttonAudioRecordOutCall
            // 
            this.buttonAudioRecordOutCall.Enabled = false;
            this.buttonAudioRecordOutCall.Location = new System.Drawing.Point(429, 18);
            this.buttonAudioRecordOutCall.Name = "buttonAudioRecordOutCall";
            this.buttonAudioRecordOutCall.Size = new System.Drawing.Size(30, 21);
            this.buttonAudioRecordOutCall.TabIndex = 8;
            this.buttonAudioRecordOutCall.Text = "...";
            this.buttonAudioRecordOutCall.UseVisualStyleBackColor = true;
            this.buttonAudioRecordOutCall.Click += new System.EventHandler(this.buttonAudioRecordOutCall_Click);
            // 
            // buttonAudioRecordInCall
            // 
            this.buttonAudioRecordInCall.Enabled = false;
            this.buttonAudioRecordInCall.Location = new System.Drawing.Point(429, 45);
            this.buttonAudioRecordInCall.Name = "buttonAudioRecordInCall";
            this.buttonAudioRecordInCall.Size = new System.Drawing.Size(30, 21);
            this.buttonAudioRecordInCall.TabIndex = 11;
            this.buttonAudioRecordInCall.Text = "...";
            this.buttonAudioRecordInCall.UseVisualStyleBackColor = true;
            this.buttonAudioRecordInCall.Click += new System.EventHandler(this.buttonAudioRecordInCall_Click);
            // 
            // checkBoxAudioRecordOutCall
            // 
            this.checkBoxAudioRecordOutCall.AutoSize = true;
            this.checkBoxAudioRecordOutCall.Location = new System.Drawing.Point(18, 21);
            this.checkBoxAudioRecordOutCall.Name = "checkBoxAudioRecordOutCall";
            this.checkBoxAudioRecordOutCall.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAudioRecordOutCall.TabIndex = 6;
            this.checkBoxAudioRecordOutCall.Text = "Outgoing Call Path :";
            this.checkBoxAudioRecordOutCall.UseVisualStyleBackColor = true;
            this.checkBoxAudioRecordOutCall.CheckedChanged += new System.EventHandler(this.checkBoxAudioRecordOutCall_CheckedChanged);
            // 
            // checkBoxAudioRecordInCall
            // 
            this.checkBoxAudioRecordInCall.AutoSize = true;
            this.checkBoxAudioRecordInCall.Location = new System.Drawing.Point(18, 47);
            this.checkBoxAudioRecordInCall.Name = "checkBoxAudioRecordInCall";
            this.checkBoxAudioRecordInCall.Size = new System.Drawing.Size(120, 17);
            this.checkBoxAudioRecordInCall.TabIndex = 9;
            this.checkBoxAudioRecordInCall.Text = "Incoming Call Path :";
            this.checkBoxAudioRecordInCall.UseVisualStyleBackColor = true;
            this.checkBoxAudioRecordInCall.CheckedChanged += new System.EventHandler(this.checkBoxAudioRecordInCall_CheckedChanged);
            // 
            // textBoxAudioRecordInCall
            // 
            this.textBoxAudioRecordInCall.Enabled = false;
            this.textBoxAudioRecordInCall.Location = new System.Drawing.Point(144, 45);
            this.textBoxAudioRecordInCall.Name = "textBoxAudioRecordInCall";
            this.textBoxAudioRecordInCall.ReadOnly = true;
            this.textBoxAudioRecordInCall.Size = new System.Drawing.Size(279, 20);
            this.textBoxAudioRecordInCall.TabIndex = 10;
            this.textBoxAudioRecordInCall.TextChanged += new System.EventHandler(this.textBoxAudioRecordinCall_TextChanged);
            // 
            // textBoxAudioRecordOutCall
            // 
            this.textBoxAudioRecordOutCall.Enabled = false;
            this.textBoxAudioRecordOutCall.Location = new System.Drawing.Point(144, 18);
            this.textBoxAudioRecordOutCall.Name = "textBoxAudioRecordOutCall";
            this.textBoxAudioRecordOutCall.ReadOnly = true;
            this.textBoxAudioRecordOutCall.Size = new System.Drawing.Size(279, 20);
            this.textBoxAudioRecordOutCall.TabIndex = 7;
            this.textBoxAudioRecordOutCall.TextChanged += new System.EventHandler(this.textBoxAudioRecordOutCall_TextChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.SupportMultiDottedExtensions = true;
            this.saveFileDialog.Title = "Recording";
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Controls.Add(this.buttonContactFilePath);
            this.groupBoxContacts.Controls.Add(this.labelContactFilePath);
            this.groupBoxContacts.Controls.Add(this.textBoxContactFilePath);
            this.groupBoxContacts.Location = new System.Drawing.Point(6, 265);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(475, 56);
            this.groupBoxContacts.TabIndex = 8;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Contacts";
            // 
            // buttonContactFilePath
            // 
            this.buttonContactFilePath.Location = new System.Drawing.Point(429, 18);
            this.buttonContactFilePath.Name = "buttonContactFilePath";
            this.buttonContactFilePath.Size = new System.Drawing.Size(30, 21);
            this.buttonContactFilePath.TabIndex = 13;
            this.buttonContactFilePath.Text = "...";
            this.buttonContactFilePath.UseVisualStyleBackColor = true;
            this.buttonContactFilePath.Click += new System.EventHandler(this.buttonContactFilePath_Click);
            // 
            // labelContactFilePath
            // 
            this.labelContactFilePath.AutoSize = true;
            this.labelContactFilePath.Location = new System.Drawing.Point(15, 22);
            this.labelContactFilePath.Name = "labelContactFilePath";
            this.labelContactFilePath.Size = new System.Drawing.Size(54, 13);
            this.labelContactFilePath.TabIndex = 1;
            this.labelContactFilePath.Text = "File Path :";
            // 
            // textBoxContactFilePath
            // 
            this.textBoxContactFilePath.Location = new System.Drawing.Point(144, 18);
            this.textBoxContactFilePath.Name = "textBoxContactFilePath";
            this.textBoxContactFilePath.ReadOnly = true;
            this.textBoxContactFilePath.Size = new System.Drawing.Size(279, 20);
            this.textBoxContactFilePath.TabIndex = 12;
            this.textBoxContactFilePath.TextChanged += new System.EventHandler(this.textBoxContactFilePath_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.SupportMultiDottedExtensions = true;
            this.openFileDialog.Title = "Contacts";
            // 
            // groupBoxCredentials
            // 
            this.groupBoxCredentials.Controls.Add(this.textBoxCredentialsPassword);
            this.groupBoxCredentials.Controls.Add(this.textBoxCredentialsUsername);
            this.groupBoxCredentials.Controls.Add(this.labelCredentialsPassword);
            this.groupBoxCredentials.Controls.Add(this.labelCredentialsUsername);
            this.groupBoxCredentials.Controls.Add(this.textBoxCredentialsSipHost);
            this.groupBoxCredentials.Controls.Add(this.textBoxCredentialsAccountName);
            this.groupBoxCredentials.Controls.Add(this.labelCredentialsSipHost);
            this.groupBoxCredentials.Controls.Add(this.labelCredentialsName);
            this.groupBoxCredentials.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCredentials.Name = "groupBoxCredentials";
            this.groupBoxCredentials.Size = new System.Drawing.Size(475, 76);
            this.groupBoxCredentials.TabIndex = 9;
            this.groupBoxCredentials.TabStop = false;
            this.groupBoxCredentials.Text = "Credentials";
            // 
            // textBoxCredentialsPassword
            // 
            this.textBoxCredentialsPassword.Location = new System.Drawing.Point(339, 45);
            this.textBoxCredentialsPassword.Name = "textBoxCredentialsPassword";
            this.textBoxCredentialsPassword.PasswordChar = '*';
            this.textBoxCredentialsPassword.Size = new System.Drawing.Size(120, 20);
            this.textBoxCredentialsPassword.TabIndex = 3;
            this.textBoxCredentialsPassword.TextChanged += new System.EventHandler(this.textBoxCredentialsPassword_TextChanged);
            // 
            // textBoxCredentialsUsername
            // 
            this.textBoxCredentialsUsername.Location = new System.Drawing.Point(339, 19);
            this.textBoxCredentialsUsername.Name = "textBoxCredentialsUsername";
            this.textBoxCredentialsUsername.Size = new System.Drawing.Size(120, 20);
            this.textBoxCredentialsUsername.TabIndex = 2;
            this.textBoxCredentialsUsername.TextChanged += new System.EventHandler(this.textBoxCredentialsUsername_TextChanged);
            // 
            // labelCredentialsPassword
            // 
            this.labelCredentialsPassword.AutoSize = true;
            this.labelCredentialsPassword.Location = new System.Drawing.Point(272, 48);
            this.labelCredentialsPassword.Name = "labelCredentialsPassword";
            this.labelCredentialsPassword.Size = new System.Drawing.Size(59, 13);
            this.labelCredentialsPassword.TabIndex = 5;
            this.labelCredentialsPassword.Text = "Password :";
            // 
            // labelCredentialsUsername
            // 
            this.labelCredentialsUsername.AutoSize = true;
            this.labelCredentialsUsername.Location = new System.Drawing.Point(272, 22);
            this.labelCredentialsUsername.Name = "labelCredentialsUsername";
            this.labelCredentialsUsername.Size = new System.Drawing.Size(61, 13);
            this.labelCredentialsUsername.TabIndex = 4;
            this.labelCredentialsUsername.Text = "Username :";
            // 
            // textBoxCredentialsSipHost
            // 
            this.textBoxCredentialsSipHost.Location = new System.Drawing.Point(105, 45);
            this.textBoxCredentialsSipHost.Name = "textBoxCredentialsSipHost";
            this.textBoxCredentialsSipHost.Size = new System.Drawing.Size(120, 20);
            this.textBoxCredentialsSipHost.TabIndex = 1;
            this.textBoxCredentialsSipHost.TextChanged += new System.EventHandler(this.textBoxCredentialsSipHost_TextChanged);
            // 
            // textBoxCredentialsAccountName
            // 
            this.textBoxCredentialsAccountName.Location = new System.Drawing.Point(105, 19);
            this.textBoxCredentialsAccountName.Name = "textBoxCredentialsAccountName";
            this.textBoxCredentialsAccountName.Size = new System.Drawing.Size(120, 20);
            this.textBoxCredentialsAccountName.TabIndex = 0;
            this.textBoxCredentialsAccountName.TextChanged += new System.EventHandler(this.textBoxCredentialsAccountName_TextChanged);
            // 
            // labelCredentialsSipHost
            // 
            this.labelCredentialsSipHost.AutoSize = true;
            this.labelCredentialsSipHost.Location = new System.Drawing.Point(15, 48);
            this.labelCredentialsSipHost.Name = "labelCredentialsSipHost";
            this.labelCredentialsSipHost.Size = new System.Drawing.Size(81, 13);
            this.labelCredentialsSipHost.TabIndex = 1;
            this.labelCredentialsSipHost.Text = "Host Name/IP :";
            // 
            // labelCredentialsName
            // 
            this.labelCredentialsName.AutoSize = true;
            this.labelCredentialsName.Location = new System.Drawing.Point(15, 22);
            this.labelCredentialsName.Name = "labelCredentialsName";
            this.labelCredentialsName.Size = new System.Drawing.Size(84, 13);
            this.labelCredentialsName.TabIndex = 0;
            this.labelCredentialsName.Text = "Account Name :";
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageDetails);
            this.tabControlSettings.Controls.Add(this.tabPageConfiguration);
            this.tabControlSettings.Controls.Add(this.tabPageMedia);
            this.tabControlSettings.Controls.Add(this.tabPageCodec);
            this.tabControlSettings.Location = new System.Drawing.Point(12, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(499, 356);
            this.tabControlSettings.TabIndex = 10;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.groupBoxCredentials);
            this.tabPageDetails.Controls.Add(this.groupBoxContacts);
            this.tabPageDetails.Controls.Add(this.groupBoxAudioDevice);
            this.tabPageDetails.Controls.Add(this.groupBoxRecording);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(491, 330);
            this.tabPageDetails.TabIndex = 0;
            this.tabPageDetails.Text = "Details";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.groupBoxPublish);
            this.tabPageConfiguration.Controls.Add(this.groupBoxAccount);
            this.tabPageConfiguration.Controls.Add(this.groupBoxTimer);
            this.tabPageConfiguration.Controls.Add(this.groupBoxTime);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Size = new System.Drawing.Size(491, 330);
            this.tabPageConfiguration.TabIndex = 2;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // groupBoxPublish
            // 
            this.groupBoxPublish.Controls.Add(this.labelPublishShutdownWaitMsec);
            this.groupBoxPublish.Controls.Add(this.textBoxPublishShutdownWait);
            this.groupBoxPublish.Controls.Add(this.labelPublishShutdownWait);
            this.groupBoxPublish.Controls.Add(this.checkBoxPublishQueue);
            this.groupBoxPublish.Controls.Add(this.checkBoxPublishEnabled);
            this.groupBoxPublish.Location = new System.Drawing.Point(194, 254);
            this.groupBoxPublish.Name = "groupBoxPublish";
            this.groupBoxPublish.Size = new System.Drawing.Size(287, 67);
            this.groupBoxPublish.TabIndex = 7;
            this.groupBoxPublish.TabStop = false;
            this.groupBoxPublish.Text = "Publish";
            // 
            // labelPublishShutdownWaitMsec
            // 
            this.labelPublishShutdownWaitMsec.AutoSize = true;
            this.labelPublishShutdownWaitMsec.Location = new System.Drawing.Point(247, 23);
            this.labelPublishShutdownWaitMsec.Name = "labelPublishShutdownWaitMsec";
            this.labelPublishShutdownWaitMsec.Size = new System.Drawing.Size(26, 13);
            this.labelPublishShutdownWaitMsec.TabIndex = 4;
            this.labelPublishShutdownWaitMsec.Text = "(ms)";
            // 
            // textBoxPublishShutdownWait
            // 
            this.textBoxPublishShutdownWait.Location = new System.Drawing.Point(181, 19);
            this.textBoxPublishShutdownWait.Name = "textBoxPublishShutdownWait";
            this.textBoxPublishShutdownWait.Size = new System.Drawing.Size(60, 20);
            this.textBoxPublishShutdownWait.TabIndex = 35;
            // 
            // labelPublishShutdownWait
            // 
            this.labelPublishShutdownWait.AutoSize = true;
            this.labelPublishShutdownWait.Location = new System.Drawing.Point(89, 22);
            this.labelPublishShutdownWait.Name = "labelPublishShutdownWait";
            this.labelPublishShutdownWait.Size = new System.Drawing.Size(86, 13);
            this.labelPublishShutdownWait.TabIndex = 2;
            this.labelPublishShutdownWait.Text = "Shutdown Wait :";
            // 
            // checkBoxPublishQueue
            // 
            this.checkBoxPublishQueue.AutoSize = true;
            this.checkBoxPublishQueue.Location = new System.Drawing.Point(18, 45);
            this.checkBoxPublishQueue.Name = "checkBoxPublishQueue";
            this.checkBoxPublishQueue.Size = new System.Drawing.Size(58, 17);
            this.checkBoxPublishQueue.TabIndex = 36;
            this.checkBoxPublishQueue.Text = "Queue";
            this.checkBoxPublishQueue.UseVisualStyleBackColor = true;
            // 
            // checkBoxPublishEnabled
            // 
            this.checkBoxPublishEnabled.AutoSize = true;
            this.checkBoxPublishEnabled.Location = new System.Drawing.Point(18, 22);
            this.checkBoxPublishEnabled.Name = "checkBoxPublishEnabled";
            this.checkBoxPublishEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxPublishEnabled.TabIndex = 34;
            this.checkBoxPublishEnabled.Text = "Enabled";
            this.checkBoxPublishEnabled.UseVisualStyleBackColor = true;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Controls.Add(this.groupBoxSounds);
            this.tabPageMedia.Controls.Add(this.groupBoxMessageWaitingIndication);
            this.tabPageMedia.Controls.Add(this.groupBoxMediaTransport);
            this.tabPageMedia.Location = new System.Drawing.Point(4, 22);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedia.Size = new System.Drawing.Size(491, 330);
            this.tabPageMedia.TabIndex = 1;
            this.tabPageMedia.Text = "Media";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // groupBoxSounds
            // 
            this.groupBoxSounds.Controls.Add(this.buttonSoundsAutoAnswer);
            this.groupBoxSounds.Controls.Add(this.textBoxSoundsAutoAnswer);
            this.groupBoxSounds.Controls.Add(this.labelSoundsAutoAnswer);
            this.groupBoxSounds.Controls.Add(this.labelSoundsAudioDevice);
            this.groupBoxSounds.Controls.Add(this.comboBoxSoundsAudioDevice);
            this.groupBoxSounds.Controls.Add(this.buttonSoundsIMPath);
            this.groupBoxSounds.Controls.Add(this.labelSoundsIMPath);
            this.groupBoxSounds.Controls.Add(this.textBoxSoundsIMPath);
            this.groupBoxSounds.Controls.Add(this.labelSoundsRingPath);
            this.groupBoxSounds.Controls.Add(this.buttonSoundsRingPath);
            this.groupBoxSounds.Controls.Add(this.textBoxSoundsRingPath);
            this.groupBoxSounds.Location = new System.Drawing.Point(6, 95);
            this.groupBoxSounds.Name = "groupBoxSounds";
            this.groupBoxSounds.Size = new System.Drawing.Size(475, 226);
            this.groupBoxSounds.TabIndex = 5;
            this.groupBoxSounds.TabStop = false;
            this.groupBoxSounds.Text = "Sounds";
            // 
            // buttonSoundsAutoAnswer
            // 
            this.buttonSoundsAutoAnswer.Location = new System.Drawing.Point(429, 100);
            this.buttonSoundsAutoAnswer.Name = "buttonSoundsAutoAnswer";
            this.buttonSoundsAutoAnswer.Size = new System.Drawing.Size(30, 21);
            this.buttonSoundsAutoAnswer.TabIndex = 56;
            this.buttonSoundsAutoAnswer.Text = "...";
            this.buttonSoundsAutoAnswer.UseVisualStyleBackColor = true;
            this.buttonSoundsAutoAnswer.Click += new System.EventHandler(this.buttonSoundsAutoAnswer_Click);
            // 
            // textBoxSoundsAutoAnswer
            // 
            this.textBoxSoundsAutoAnswer.Location = new System.Drawing.Point(144, 100);
            this.textBoxSoundsAutoAnswer.Name = "textBoxSoundsAutoAnswer";
            this.textBoxSoundsAutoAnswer.Size = new System.Drawing.Size(279, 20);
            this.textBoxSoundsAutoAnswer.TabIndex = 55;
            this.textBoxSoundsAutoAnswer.TextChanged += new System.EventHandler(this.textBoxSoundsAutoAnswer_TextChanged);
            // 
            // labelSoundsAutoAnswer
            // 
            this.labelSoundsAutoAnswer.AutoSize = true;
            this.labelSoundsAutoAnswer.Location = new System.Drawing.Point(15, 103);
            this.labelSoundsAutoAnswer.Name = "labelSoundsAutoAnswer";
            this.labelSoundsAutoAnswer.Size = new System.Drawing.Size(73, 13);
            this.labelSoundsAutoAnswer.TabIndex = 8;
            this.labelSoundsAutoAnswer.Text = "Auto Answer :";
            // 
            // labelSoundsAudioDevice
            // 
            this.labelSoundsAudioDevice.AutoSize = true;
            this.labelSoundsAudioDevice.Location = new System.Drawing.Point(15, 22);
            this.labelSoundsAudioDevice.Name = "labelSoundsAudioDevice";
            this.labelSoundsAudioDevice.Size = new System.Drawing.Size(77, 13);
            this.labelSoundsAudioDevice.TabIndex = 7;
            this.labelSoundsAudioDevice.Text = "Audio Device :";
            // 
            // comboBoxSoundsAudioDevice
            // 
            this.comboBoxSoundsAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSoundsAudioDevice.FormattingEnabled = true;
            this.comboBoxSoundsAudioDevice.Location = new System.Drawing.Point(144, 19);
            this.comboBoxSoundsAudioDevice.Name = "comboBoxSoundsAudioDevice";
            this.comboBoxSoundsAudioDevice.Size = new System.Drawing.Size(315, 21);
            this.comboBoxSoundsAudioDevice.TabIndex = 50;
            this.comboBoxSoundsAudioDevice.SelectedIndexChanged += new System.EventHandler(this.comboBoxSoundsAudioDevice_SelectedIndexChanged);
            // 
            // buttonSoundsIMPath
            // 
            this.buttonSoundsIMPath.Location = new System.Drawing.Point(429, 74);
            this.buttonSoundsIMPath.Name = "buttonSoundsIMPath";
            this.buttonSoundsIMPath.Size = new System.Drawing.Size(30, 21);
            this.buttonSoundsIMPath.TabIndex = 54;
            this.buttonSoundsIMPath.Text = "...";
            this.buttonSoundsIMPath.UseVisualStyleBackColor = true;
            this.buttonSoundsIMPath.Click += new System.EventHandler(this.buttonSoundsIMPath_Click);
            // 
            // labelSoundsIMPath
            // 
            this.labelSoundsIMPath.AutoSize = true;
            this.labelSoundsIMPath.Location = new System.Drawing.Point(15, 77);
            this.labelSoundsIMPath.Name = "labelSoundsIMPath";
            this.labelSoundsIMPath.Size = new System.Drawing.Size(91, 13);
            this.labelSoundsIMPath.TabIndex = 4;
            this.labelSoundsIMPath.Text = "Instant Message :";
            // 
            // textBoxSoundsIMPath
            // 
            this.textBoxSoundsIMPath.Location = new System.Drawing.Point(144, 74);
            this.textBoxSoundsIMPath.Name = "textBoxSoundsIMPath";
            this.textBoxSoundsIMPath.Size = new System.Drawing.Size(279, 20);
            this.textBoxSoundsIMPath.TabIndex = 53;
            this.textBoxSoundsIMPath.TextChanged += new System.EventHandler(this.textBoxSoundsIMPath_TextChanged);
            // 
            // labelSoundsRingPath
            // 
            this.labelSoundsRingPath.AutoSize = true;
            this.labelSoundsRingPath.Location = new System.Drawing.Point(15, 49);
            this.labelSoundsRingPath.Name = "labelSoundsRingPath";
            this.labelSoundsRingPath.Size = new System.Drawing.Size(79, 13);
            this.labelSoundsRingPath.TabIndex = 2;
            this.labelSoundsRingPath.Text = "In coming Call :";
            // 
            // buttonSoundsRingPath
            // 
            this.buttonSoundsRingPath.Location = new System.Drawing.Point(429, 46);
            this.buttonSoundsRingPath.Name = "buttonSoundsRingPath";
            this.buttonSoundsRingPath.Size = new System.Drawing.Size(30, 21);
            this.buttonSoundsRingPath.TabIndex = 52;
            this.buttonSoundsRingPath.Text = "...";
            this.buttonSoundsRingPath.UseVisualStyleBackColor = true;
            this.buttonSoundsRingPath.Click += new System.EventHandler(this.buttonSoundsRingPath_Click);
            // 
            // textBoxSoundsRingPath
            // 
            this.textBoxSoundsRingPath.Location = new System.Drawing.Point(144, 46);
            this.textBoxSoundsRingPath.Name = "textBoxSoundsRingPath";
            this.textBoxSoundsRingPath.Size = new System.Drawing.Size(279, 20);
            this.textBoxSoundsRingPath.TabIndex = 51;
            this.textBoxSoundsRingPath.TextChanged += new System.EventHandler(this.textBoxSoundsRingPath_TextChanged);
            // 
            // tabPageCodec
            // 
            this.tabPageCodec.Controls.Add(this.groupBoxVideoCodec);
            this.tabPageCodec.Controls.Add(this.groupBoxAudioCodec);
            this.tabPageCodec.Controls.Add(this.groupBoxFeatureTransferCall);
            this.tabPageCodec.Controls.Add(this.groupBoxVideoDevice);
            this.tabPageCodec.Location = new System.Drawing.Point(4, 22);
            this.tabPageCodec.Name = "tabPageCodec";
            this.tabPageCodec.Size = new System.Drawing.Size(491, 330);
            this.tabPageCodec.TabIndex = 3;
            this.tabPageCodec.Text = "Feature";
            this.tabPageCodec.UseVisualStyleBackColor = true;
            // 
            // groupBoxVideoCodec
            // 
            this.groupBoxVideoCodec.Controls.Add(this.checkedListBoxVideoCodec);
            this.groupBoxVideoCodec.Location = new System.Drawing.Point(248, 177);
            this.groupBoxVideoCodec.Name = "groupBoxVideoCodec";
            this.groupBoxVideoCodec.Size = new System.Drawing.Size(233, 144);
            this.groupBoxVideoCodec.TabIndex = 5;
            this.groupBoxVideoCodec.TabStop = false;
            this.groupBoxVideoCodec.Text = "Video Codecs";
            // 
            // checkedListBoxVideoCodec
            // 
            this.checkedListBoxVideoCodec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxVideoCodec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxVideoCodec.ContextMenuStrip = this.contextMenuStripVideoCodecPriority;
            this.checkedListBoxVideoCodec.FormattingEnabled = true;
            this.checkedListBoxVideoCodec.IntegralHeight = false;
            this.checkedListBoxVideoCodec.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxVideoCodec.Name = "checkedListBoxVideoCodec";
            this.checkedListBoxVideoCodec.Size = new System.Drawing.Size(221, 119);
            this.checkedListBoxVideoCodec.TabIndex = 49;
            this.checkedListBoxVideoCodec.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxVideoCodec_ItemCheck);
            this.checkedListBoxVideoCodec.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxVideoCodec_SelectedIndexChanged);
            // 
            // contextMenuStripVideoCodecPriority
            // 
            this.contextMenuStripVideoCodecPriority.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVideoChangePriority});
            this.contextMenuStripVideoCodecPriority.Name = "contextMenuStripVideoCodecPriority";
            this.contextMenuStripVideoCodecPriority.Size = new System.Drawing.Size(157, 26);
            // 
            // toolStripMenuItemVideoChangePriority
            // 
            this.toolStripMenuItemVideoChangePriority.Enabled = false;
            this.toolStripMenuItemVideoChangePriority.Name = "toolStripMenuItemVideoChangePriority";
            this.toolStripMenuItemVideoChangePriority.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemVideoChangePriority.Text = "Change Priority";
            this.toolStripMenuItemVideoChangePriority.Click += new System.EventHandler(this.toolStripMenuItemChangePriority_Click);
            // 
            // groupBoxAudioCodec
            // 
            this.groupBoxAudioCodec.Controls.Add(this.checkedListBoxAudioCodec);
            this.groupBoxAudioCodec.Location = new System.Drawing.Point(6, 177);
            this.groupBoxAudioCodec.Name = "groupBoxAudioCodec";
            this.groupBoxAudioCodec.Size = new System.Drawing.Size(233, 144);
            this.groupBoxAudioCodec.TabIndex = 4;
            this.groupBoxAudioCodec.TabStop = false;
            this.groupBoxAudioCodec.Text = "Audio Codecs";
            // 
            // checkedListBoxAudioCodec
            // 
            this.checkedListBoxAudioCodec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxAudioCodec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAudioCodec.ContextMenuStrip = this.contextMenuStripCodecPriority;
            this.checkedListBoxAudioCodec.FormattingEnabled = true;
            this.checkedListBoxAudioCodec.IntegralHeight = false;
            this.checkedListBoxAudioCodec.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxAudioCodec.Name = "checkedListBoxAudioCodec";
            this.checkedListBoxAudioCodec.Size = new System.Drawing.Size(221, 119);
            this.checkedListBoxAudioCodec.TabIndex = 48;
            this.checkedListBoxAudioCodec.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxAudioCodec_ItemCheck);
            this.checkedListBoxAudioCodec.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAudioCodec_SelectedIndexChanged);
            // 
            // contextMenuStripCodecPriority
            // 
            this.contextMenuStripCodecPriority.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChangePriority});
            this.contextMenuStripCodecPriority.Name = "contextMenuStripCodecPriority";
            this.contextMenuStripCodecPriority.Size = new System.Drawing.Size(157, 26);
            // 
            // toolStripMenuItemChangePriority
            // 
            this.toolStripMenuItemChangePriority.Enabled = false;
            this.toolStripMenuItemChangePriority.Name = "toolStripMenuItemChangePriority";
            this.toolStripMenuItemChangePriority.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItemChangePriority.Text = "Change Priority";
            this.toolStripMenuItemChangePriority.Click += new System.EventHandler(this.toolStripMenuItemChangePriority_Click);
            // 
            // groupBoxFeatureTransferCall
            // 
            this.groupBoxFeatureTransferCall.Controls.Add(this.labelRedirectCallToNumber);
            this.groupBoxFeatureTransferCall.Controls.Add(this.labelRedirectCallTimeSec);
            this.groupBoxFeatureTransferCall.Controls.Add(this.textBoxRedirectCallTime);
            this.groupBoxFeatureTransferCall.Controls.Add(this.labelRedirectCallTime);
            this.groupBoxFeatureTransferCall.Controls.Add(this.textBoxRedirectCallText);
            this.groupBoxFeatureTransferCall.Controls.Add(this.checkBoxRedirectCallEnabled);
            this.groupBoxFeatureTransferCall.Location = new System.Drawing.Point(6, 113);
            this.groupBoxFeatureTransferCall.Name = "groupBoxFeatureTransferCall";
            this.groupBoxFeatureTransferCall.Size = new System.Drawing.Size(475, 58);
            this.groupBoxFeatureTransferCall.TabIndex = 1;
            this.groupBoxFeatureTransferCall.TabStop = false;
            this.groupBoxFeatureTransferCall.Text = "Redirect Call";
            // 
            // labelRedirectCallToNumber
            // 
            this.labelRedirectCallToNumber.AutoSize = true;
            this.labelRedirectCallToNumber.Location = new System.Drawing.Point(89, 23);
            this.labelRedirectCallToNumber.Name = "labelRedirectCallToNumber";
            this.labelRedirectCallToNumber.Size = new System.Drawing.Size(26, 13);
            this.labelRedirectCallToNumber.TabIndex = 5;
            this.labelRedirectCallToNumber.Text = "To :";
            // 
            // labelRedirectCallTimeSec
            // 
            this.labelRedirectCallTimeSec.AutoSize = true;
            this.labelRedirectCallTimeSec.Location = new System.Drawing.Point(448, 23);
            this.labelRedirectCallTimeSec.Name = "labelRedirectCallTimeSec";
            this.labelRedirectCallTimeSec.Size = new System.Drawing.Size(18, 13);
            this.labelRedirectCallTimeSec.TabIndex = 4;
            this.labelRedirectCallTimeSec.Text = "(s)";
            // 
            // textBoxRedirectCallTime
            // 
            this.textBoxRedirectCallTime.Location = new System.Drawing.Point(372, 20);
            this.textBoxRedirectCallTime.Name = "textBoxRedirectCallTime";
            this.textBoxRedirectCallTime.ReadOnly = true;
            this.textBoxRedirectCallTime.Size = new System.Drawing.Size(70, 20);
            this.textBoxRedirectCallTime.TabIndex = 47;
            this.textBoxRedirectCallTime.TextChanged += new System.EventHandler(this.textBoxRedirectCallTime_TextChanged);
            // 
            // labelRedirectCallTime
            // 
            this.labelRedirectCallTime.AutoSize = true;
            this.labelRedirectCallTime.Location = new System.Drawing.Point(331, 23);
            this.labelRedirectCallTime.Name = "labelRedirectCallTime";
            this.labelRedirectCallTime.Size = new System.Drawing.Size(35, 13);
            this.labelRedirectCallTime.TabIndex = 2;
            this.labelRedirectCallTime.Text = "After :";
            // 
            // textBoxRedirectCallText
            // 
            this.textBoxRedirectCallText.Location = new System.Drawing.Point(121, 20);
            this.textBoxRedirectCallText.Name = "textBoxRedirectCallText";
            this.textBoxRedirectCallText.ReadOnly = true;
            this.textBoxRedirectCallText.Size = new System.Drawing.Size(187, 20);
            this.textBoxRedirectCallText.TabIndex = 46;
            this.textBoxRedirectCallText.TextChanged += new System.EventHandler(this.textBoxRedirectCallText_TextChanged);
            // 
            // checkBoxRedirectCallEnabled
            // 
            this.checkBoxRedirectCallEnabled.AutoSize = true;
            this.checkBoxRedirectCallEnabled.Location = new System.Drawing.Point(18, 22);
            this.checkBoxRedirectCallEnabled.Name = "checkBoxRedirectCallEnabled";
            this.checkBoxRedirectCallEnabled.Size = new System.Drawing.Size(65, 17);
            this.checkBoxRedirectCallEnabled.TabIndex = 45;
            this.checkBoxRedirectCallEnabled.Text = "Enabled";
            this.checkBoxRedirectCallEnabled.UseVisualStyleBackColor = true;
            this.checkBoxRedirectCallEnabled.CheckedChanged += new System.EventHandler(this.checkBoxRedirectCallEnabled_CheckedChanged);
            // 
            // groupBoxVideoDevice
            // 
            this.groupBoxVideoDevice.Controls.Add(this.labelVideoBandwidthRateBits);
            this.groupBoxVideoDevice.Controls.Add(this.textBoxVideoBandwidthRate);
            this.groupBoxVideoDevice.Controls.Add(this.labelVideoBandwidthRate);
            this.groupBoxVideoDevice.Controls.Add(this.checkBoxVideo);
            this.groupBoxVideoDevice.Controls.Add(this.comboBoxVideoDevicePlayback);
            this.groupBoxVideoDevice.Controls.Add(this.comboBoxVideoDeviceCapture);
            this.groupBoxVideoDevice.Controls.Add(this.labelVideoDevicePlayback);
            this.groupBoxVideoDevice.Controls.Add(this.labelVideoDeviceCapture);
            this.groupBoxVideoDevice.Location = new System.Drawing.Point(6, 6);
            this.groupBoxVideoDevice.Name = "groupBoxVideoDevice";
            this.groupBoxVideoDevice.Size = new System.Drawing.Size(475, 101);
            this.groupBoxVideoDevice.TabIndex = 0;
            this.groupBoxVideoDevice.TabStop = false;
            this.groupBoxVideoDevice.Text = "Video Device";
            // 
            // labelVideoBandwidthRateBits
            // 
            this.labelVideoBandwidthRateBits.AutoSize = true;
            this.labelVideoBandwidthRateBits.Location = new System.Drawing.Point(279, 76);
            this.labelVideoBandwidthRateBits.Name = "labelVideoBandwidthRateBits";
            this.labelVideoBandwidthRateBits.Size = new System.Drawing.Size(39, 13);
            this.labelVideoBandwidthRateBits.TabIndex = 7;
            this.labelVideoBandwidthRateBits.Text = "(bits/s)";
            // 
            // textBoxVideoBandwidthRate
            // 
            this.textBoxVideoBandwidthRate.Location = new System.Drawing.Point(213, 73);
            this.textBoxVideoBandwidthRate.Name = "textBoxVideoBandwidthRate";
            this.textBoxVideoBandwidthRate.Size = new System.Drawing.Size(60, 20);
            this.textBoxVideoBandwidthRate.TabIndex = 44;
            this.textBoxVideoBandwidthRate.TextChanged += new System.EventHandler(this.textBoxVideoBandwidthRate_TextChanged);
            // 
            // labelVideoBandwidthRate
            // 
            this.labelVideoBandwidthRate.AutoSize = true;
            this.labelVideoBandwidthRate.Location = new System.Drawing.Point(118, 76);
            this.labelVideoBandwidthRate.Name = "labelVideoBandwidthRate";
            this.labelVideoBandwidthRate.Size = new System.Drawing.Size(89, 13);
            this.labelVideoBandwidthRate.TabIndex = 5;
            this.labelVideoBandwidthRate.Text = "Bandwidth Rate :";
            // 
            // checkBoxVideo
            // 
            this.checkBoxVideo.AutoSize = true;
            this.checkBoxVideo.Location = new System.Drawing.Point(18, 75);
            this.checkBoxVideo.Name = "checkBoxVideo";
            this.checkBoxVideo.Size = new System.Drawing.Size(89, 17);
            this.checkBoxVideo.TabIndex = 43;
            this.checkBoxVideo.Text = "Enable Video";
            this.checkBoxVideo.UseVisualStyleBackColor = true;
            this.checkBoxVideo.CheckedChanged += new System.EventHandler(this.checkBoxVideo_CheckedChanged);
            // 
            // comboBoxVideoDevicePlayback
            // 
            this.comboBoxVideoDevicePlayback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoDevicePlayback.FormattingEnabled = true;
            this.comboBoxVideoDevicePlayback.Location = new System.Drawing.Point(78, 46);
            this.comboBoxVideoDevicePlayback.Name = "comboBoxVideoDevicePlayback";
            this.comboBoxVideoDevicePlayback.Size = new System.Drawing.Size(381, 21);
            this.comboBoxVideoDevicePlayback.TabIndex = 42;
            this.comboBoxVideoDevicePlayback.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoDevicePlayback_SelectedIndexChanged);
            // 
            // comboBoxVideoDeviceCapture
            // 
            this.comboBoxVideoDeviceCapture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideoDeviceCapture.FormattingEnabled = true;
            this.comboBoxVideoDeviceCapture.Location = new System.Drawing.Point(78, 19);
            this.comboBoxVideoDeviceCapture.Name = "comboBoxVideoDeviceCapture";
            this.comboBoxVideoDeviceCapture.Size = new System.Drawing.Size(381, 21);
            this.comboBoxVideoDeviceCapture.TabIndex = 41;
            this.comboBoxVideoDeviceCapture.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideoDeviceCapture_SelectedIndexChanged);
            // 
            // labelVideoDevicePlayback
            // 
            this.labelVideoDevicePlayback.AutoSize = true;
            this.labelVideoDevicePlayback.Location = new System.Drawing.Point(15, 49);
            this.labelVideoDevicePlayback.Name = "labelVideoDevicePlayback";
            this.labelVideoDevicePlayback.Size = new System.Drawing.Size(57, 13);
            this.labelVideoDevicePlayback.TabIndex = 1;
            this.labelVideoDevicePlayback.Text = "Playback :";
            // 
            // labelVideoDeviceCapture
            // 
            this.labelVideoDeviceCapture.AutoSize = true;
            this.labelVideoDeviceCapture.Location = new System.Drawing.Point(15, 22);
            this.labelVideoDeviceCapture.Name = "labelVideoDeviceCapture";
            this.labelVideoDeviceCapture.Size = new System.Drawing.Size(50, 13);
            this.labelVideoDeviceCapture.TabIndex = 0;
            this.labelVideoDeviceCapture.Text = "Capture :";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 380);
            this.Controls.Add(this.tabControlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBoxAudioDevice.ResumeLayout(false);
            this.groupBoxAudioDevice.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.groupBoxMessageWaitingIndication.ResumeLayout(false);
            this.groupBoxMessageWaitingIndication.PerformLayout();
            this.groupBoxMediaTransport.ResumeLayout(false);
            this.groupBoxMediaTransport.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxTimer.ResumeLayout(false);
            this.groupBoxTimer.PerformLayout();
            this.groupBoxRecording.ResumeLayout(false);
            this.groupBoxRecording.PerformLayout();
            this.groupBoxContacts.ResumeLayout(false);
            this.groupBoxContacts.PerformLayout();
            this.groupBoxCredentials.ResumeLayout(false);
            this.groupBoxCredentials.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.groupBoxPublish.ResumeLayout(false);
            this.groupBoxPublish.PerformLayout();
            this.tabPageMedia.ResumeLayout(false);
            this.groupBoxSounds.ResumeLayout(false);
            this.groupBoxSounds.PerformLayout();
            this.tabPageCodec.ResumeLayout(false);
            this.groupBoxVideoCodec.ResumeLayout(false);
            this.contextMenuStripVideoCodecPriority.ResumeLayout(false);
            this.groupBoxAudioCodec.ResumeLayout(false);
            this.contextMenuStripCodecPriority.ResumeLayout(false);
            this.groupBoxFeatureTransferCall.ResumeLayout(false);
            this.groupBoxFeatureTransferCall.PerformLayout();
            this.groupBoxVideoDevice.ResumeLayout(false);
            this.groupBoxVideoDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAudioDevice;
        private System.Windows.Forms.ComboBox comboBoxAudioPlaybackDevice;
        private System.Windows.Forms.ComboBox comboBoxAudioCaptureDevice;
        private System.Windows.Forms.Label labelAudioPlaybackDevice;
        private System.Windows.Forms.Label labelAudioCaptureDevice;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.CheckBox checkBoxIsDefault;
        private System.Windows.Forms.TextBox textBoxSipPort;
        private System.Windows.Forms.Label labelSipPort;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.CheckBox checkBoxDropCallsOnFail;
        private System.Windows.Forms.CheckBox checkBoxSrtpSecureSignaling;
        private System.Windows.Forms.CheckBox checkBoxUseSrtp;
        private System.Windows.Forms.CheckBox checkBoxUseIPv6;
        private System.Windows.Forms.CheckBox checkBoxIceEnabled;
        private System.Windows.Forms.CheckBox checkBoxNoIceRtcp;
        private System.Windows.Forms.CheckBox checkBoxRegisterOnAdd;
        private System.Windows.Forms.GroupBox groupBoxMessageWaitingIndication;
        private System.Windows.Forms.Label labelMwiExpirationSec;
        private System.Windows.Forms.TextBox textBoxMwiExpiration;
        private System.Windows.Forms.Label labelMwiExpiration;
        private System.Windows.Forms.CheckBox checkBoxMessageWaitingIndicationEnabled;
        private System.Windows.Forms.GroupBox groupBoxMediaTransport;
        private System.Windows.Forms.TextBox textBoxMediaTransportPortRange;
        private System.Windows.Forms.Label labelMediaTransportPortRange;
        private System.Windows.Forms.TextBox textBoxMediaTransportPort;
        private System.Windows.Forms.Label labelMediaTransportPort;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label labelTimeUnregisterWaitSec;
        private System.Windows.Forms.Label labelTimeTimeoutSec;
        private System.Windows.Forms.Label labelTimeUnregisterWait;
        private System.Windows.Forms.TextBox textBoxTimeUnregisterWait;
        private System.Windows.Forms.TextBox textBoxTimeTimeout;
        private System.Windows.Forms.Label labelTimeTimeout;
        private System.Windows.Forms.Label labelDelayBeforeRefreshSec;
        private System.Windows.Forms.Label labelTimeFirstRetryIntervalSec;
        private System.Windows.Forms.Label labelTimeRetryIntervalSec;
        private System.Windows.Forms.Label labelTimeDelayBeforeRefresh;
        private System.Windows.Forms.TextBox textBoxTimeDelayBeforeRefresh;
        private System.Windows.Forms.TextBox textBoxTimeFirstRetryInterval;
        private System.Windows.Forms.TextBox textBoxTimeRetryInterval;
        private System.Windows.Forms.Label labelTimeFirstRetryInterval;
        private System.Windows.Forms.Label labelTimeRetryInterval;
        private System.Windows.Forms.GroupBox groupBoxTimer;
        private System.Windows.Forms.Label labelTimerSessExpiresSec;
        private System.Windows.Forms.TextBox textBoxTimerSessExpires;
        private System.Windows.Forms.Label labelTimerSessExpires;
        private System.Windows.Forms.Label labelTimerMinSESec;
        private System.Windows.Forms.TextBox textBoxTimerMinSE;
        private System.Windows.Forms.Label labelTimerMinSE;
        private System.Windows.Forms.GroupBox groupBoxRecording;
        private System.Windows.Forms.TextBox textBoxAudioRecordInCall;
        private System.Windows.Forms.TextBox textBoxAudioRecordOutCall;
        private System.Windows.Forms.CheckBox checkBoxAudioRecordInCall;
        private System.Windows.Forms.Button buttonAudioRecordOutCall;
        private System.Windows.Forms.Button buttonAudioRecordInCall;
        private System.Windows.Forms.CheckBox checkBoxAudioRecordOutCall;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.Label labelContactFilePath;
        private System.Windows.Forms.TextBox textBoxContactFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonContactFilePath;
        private System.Windows.Forms.GroupBox groupBoxCredentials;
        private System.Windows.Forms.TextBox textBoxCredentialsPassword;
        private System.Windows.Forms.TextBox textBoxCredentialsUsername;
        private System.Windows.Forms.Label labelCredentialsPassword;
        private System.Windows.Forms.Label labelCredentialsUsername;
        private System.Windows.Forms.TextBox textBoxCredentialsSipHost;
        private System.Windows.Forms.TextBox textBoxCredentialsAccountName;
        private System.Windows.Forms.Label labelCredentialsSipHost;
        private System.Windows.Forms.Label labelCredentialsName;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageDetails;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageMedia;
        private System.Windows.Forms.CheckBox checkBoxPublishEnabled;
        private System.Windows.Forms.CheckBox checkBoxPublishQueue;
        private System.Windows.Forms.Label labelPublishShutdownWait;
        private System.Windows.Forms.TextBox textBoxPublishShutdownWait;
        private System.Windows.Forms.Label labelPublishShutdownWaitMsec;
        private System.Windows.Forms.GroupBox groupBoxPublish;
        private System.Windows.Forms.GroupBox groupBoxSounds;
        private System.Windows.Forms.TextBox textBoxSoundsRingPath;
        private System.Windows.Forms.Label labelSoundsRingPath;
        private System.Windows.Forms.Button buttonSoundsRingPath;
        private System.Windows.Forms.Button buttonSoundsIMPath;
        private System.Windows.Forms.Label labelSoundsIMPath;
        private System.Windows.Forms.TextBox textBoxSoundsIMPath;
        private System.Windows.Forms.Label labelSoundsAudioDevice;
        private System.Windows.Forms.ComboBox comboBoxSoundsAudioDevice;
        private System.Windows.Forms.Button buttonSoundsAutoAnswer;
        private System.Windows.Forms.TextBox textBoxSoundsAutoAnswer;
        private System.Windows.Forms.Label labelSoundsAutoAnswer;
        private System.Windows.Forms.CheckBox checkBoxAutoAnswer;
        private System.Windows.Forms.Label labelAutoAnswerWaitSec;
        private System.Windows.Forms.TextBox textBoxAutoAnswerWait;
        private System.Windows.Forms.Label labelMessageBankWaitSec;
        private System.Windows.Forms.TextBox textBoxMessageBankWait;
        private System.Windows.Forms.Label labelMessageBankWait;
        private System.Windows.Forms.TabPage tabPageCodec;
        private System.Windows.Forms.GroupBox groupBoxVideoDevice;
        private System.Windows.Forms.CheckBox checkBoxVideo;
        private System.Windows.Forms.ComboBox comboBoxVideoDevicePlayback;
        private System.Windows.Forms.ComboBox comboBoxVideoDeviceCapture;
        private System.Windows.Forms.Label labelVideoDevicePlayback;
        private System.Windows.Forms.Label labelVideoDeviceCapture;
        private System.Windows.Forms.GroupBox groupBoxFeatureTransferCall;
        private System.Windows.Forms.Label labelRedirectCallTimeSec;
        private System.Windows.Forms.TextBox textBoxRedirectCallTime;
        private System.Windows.Forms.Label labelRedirectCallTime;
        private System.Windows.Forms.TextBox textBoxRedirectCallText;
        private System.Windows.Forms.CheckBox checkBoxRedirectCallEnabled;
        private System.Windows.Forms.Label labelRedirectCallToNumber;
        private System.Windows.Forms.Label labelVideoBandwidthRateBits;
        private System.Windows.Forms.TextBox textBoxVideoBandwidthRate;
        private System.Windows.Forms.Label labelVideoBandwidthRate;
        private System.Windows.Forms.CheckedListBox checkedListBoxAudioCodec;
        private System.Windows.Forms.CheckedListBox checkedListBoxVideoCodec;
        private System.Windows.Forms.GroupBox groupBoxAudioCodec;
        private System.Windows.Forms.GroupBox groupBoxVideoCodec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCodecPriority;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChangePriority;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripVideoCodecPriority;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVideoChangePriority;
    }
}