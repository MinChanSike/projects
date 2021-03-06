/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2015 http://www.nequeo.com.au/
*
*  File :          OnRegStateParam.h
*  Purpose :       SIP OnRegStateParam class.
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

#ifndef _ONREGSTATEPARAM_H
#define _ONREGSTATEPARAM_H

#include "stdafx.h"

#include "SipRxData.h"
#include "StatusCode.h"

#include "pjsua2.hpp"

using namespace System;
using namespace System::Collections;
using namespace System::Collections::Generic;

namespace Nequeo
{
	namespace Net
	{
		namespace PjSip
		{
			///	<summary>
			///	On registration state paramters.
			///	</summary>
			public ref class OnRegStateParam sealed
			{
			public:
				///	<summary>
				///	On registration state paramters.
				///	</summary>
				OnRegStateParam();

				/// <summary>
				/// Gets or sets the SIP status code of the transaction.
				/// </summary>
				property StatusCode Code
				{
					StatusCode get();
					void set(StatusCode value);
				}

				/// <summary>
				/// Gets or sets the next expiration interval.
				/// </summary>
				property int Expiration
				{
					int get();
					void set(int value);
				}

				/// <summary>
				/// Gets or sets the incoming INVITE request.
				/// </summary>
				property SipRxData^ RxData
				{
					SipRxData^ get();
					void set(SipRxData^ value);
				}

				/// <summary>
				/// Gets or sets the SIP reason phrase received.
				/// </summary>
				property String^ Reason
				{
					String^ get();
					void set(String^ value);
				}

				/// <summary>
				/// Gets or sets the Registration operation status.
				/// </summary>
				property int Status
				{
					int get();
					void set(int value);
				}

			private:
				StatusCode _code;
				int _expiration;
				SipRxData^ _rxData;
				String^ _reason;
				int _status;
			};
		}
	}
}
#endif