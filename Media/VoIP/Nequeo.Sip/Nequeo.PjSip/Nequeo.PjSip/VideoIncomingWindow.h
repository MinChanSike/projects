/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2015 http://www.nequeo.com.au/
*
*  File :          VideoIncomingWindow.h
*  Purpose :       VideoIncomingWindow class.
*
*/

/*
Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

#pragma once

namespace Nequeo
{
	namespace Net
	{
		namespace PjSip
		{
			namespace UI
			{

				using namespace System;
				using namespace System::ComponentModel;
				using namespace System::Collections;
				using namespace System::Windows::Forms;
				using namespace System::Data;
				using namespace System::Drawing;

				/// <summary>
				/// Summary for VideoIncomingWindow
				/// </summary>
				public ref class VideoIncomingWindow : public System::Windows::Forms::Form
				{
				public:
					/// <summary>
					/// Summary for VideoIncomingWindow
					/// </summary>
					/// <param name="videoWindowID">The video window id (>= 0).</param>
					/// <param name="windowTitle">The video window title.</param>
					/// <param name="callID">The video call unique id.</param>
					/// <param name="windowWidth">The video window width.</param>
					/// <param name="windowHeight">The video window height.</param>
					VideoIncomingWindow(int videoWindowID, String^ windowTitle, String^ callID, int windowWidth, int windowHeight) : _isActive(true)
					{
						InitializeComponent();
						
						_videoWindowID = videoWindowID;
						_windowHeight = windowHeight;
						_windowWidth = windowWidth;
						this->Text = windowTitle;
						_callID = callID;
					}

					/// <summary>
					/// Form is closing.
					/// </summary>
					event System::EventHandler<String^>^ OnVideoIncomingClosing;

					/// <summary>
					/// Show the video window.
					/// </summary>
					void ShowVideoWindow();

					/// <summary>
					/// Hide the video window.
					/// </summary>
					void HideVideoWindow();

					/// <summary>
					/// Set the window active state.
					/// </summary>
					/// <param name="state">The window active state.</param>
					void SetActiveState(bool state);

					/// <summary>
					/// Get the window active state.
					/// </summary>
					/// <return>The window active state.</return>
					bool GetActiveState();

					/// <summary>
					/// Get the video call id
					/// </summary>
					/// <return>The video call id.</return>
					String^ GetCallID();

				private:
					int _videoWindowID;
					int _windowHeight;
					int _windowWidth;
					bool _isActive;
					String^ _callID;

					/// <summary>
					/// Create the preview.
					/// </summary>
					void Create();

				protected:
					/// <summary>
					/// Clean up any resources being used.
					/// </summary>
					~VideoIncomingWindow()
					{
						if (components)
						{
							delete components;
						}
					}

				private:
					/// <summary>
					/// Required designer variable.
					/// </summary>
					System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
					/// <summary>
					/// Required method for Designer support - do not modify
					/// the contents of this method with the code editor.
					/// </summary>
					void InitializeComponent(void)
					{
						this->SuspendLayout();
						// 
						// VideoIncomingWindow
						// 
						this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
						this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
						this->ClientSize = System::Drawing::Size(239, 171);
						this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedDialog;
						this->MaximizeBox = false;
						this->Name = L"VideoIncomingWindow";
						this->ShowIcon = false;
						this->StartPosition = System::Windows::Forms::FormStartPosition::CenterParent;
						this->Text = L"Video";
						this->FormClosing += gcnew System::Windows::Forms::FormClosingEventHandler(this, &VideoIncomingWindow::VideoIncomingWindow_FormClosing);
						this->Load += gcnew System::EventHandler(this, &VideoIncomingWindow::VideoIncomingWindow_Load);
						this->ResizeEnd += gcnew System::EventHandler(this, &VideoIncomingWindow::VideoIncomingWindow_ResizeEnd);
						this->ResumeLayout(false);

					}
#pragma endregion

				private: System::Void VideoIncomingWindow_Load(System::Object^  sender, System::EventArgs^  e);
				private: System::Void VideoIncomingWindow_FormClosing(System::Object^  sender, System::Windows::Forms::FormClosingEventArgs^  e);
				private: System::Void VideoIncomingWindow_ResizeEnd(System::Object^  sender, System::EventArgs^  e);
				
				};
			}
		}
	}
}