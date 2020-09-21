// Copyright © 2020 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.
namespace CefSharp.DevTools.Input
{
    using System.Linq;

    /// <summary>
    /// Input
    /// </summary>
    public partial class Input : DevToolsDomainBase
    {
        private CefSharp.DevTools.IDevToolsClient _client;
        public Input(CefSharp.DevTools.IDevToolsClient client)
        {
            _client = (client);
        }

        partial void ValidateDispatchKeyEvent(string type, int? modifiers = null, long? timestamp = null, string text = null, string unmodifiedText = null, string keyIdentifier = null, string code = null, string key = null, int? windowsVirtualKeyCode = null, int? nativeVirtualKeyCode = null, bool? autoRepeat = null, bool? isKeypad = null, bool? isSystemKey = null, int? location = null, string[] commands = null);
        /// <summary>
        /// Dispatches a key event to the page.
        /// </summary>
        /// <param name = "type">Type of the key event.</param>
        /// <param name = "modifiers">Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> DispatchKeyEventAsync(string type, int? modifiers = null, long? timestamp = null, string text = null, string unmodifiedText = null, string keyIdentifier = null, string code = null, string key = null, int? windowsVirtualKeyCode = null, int? nativeVirtualKeyCode = null, bool? autoRepeat = null, bool? isKeypad = null, bool? isSystemKey = null, int? location = null, string[] commands = null)
        {
            ValidateDispatchKeyEvent(type, modifiers, timestamp, text, unmodifiedText, keyIdentifier, code, key, windowsVirtualKeyCode, nativeVirtualKeyCode, autoRepeat, isKeypad, isSystemKey, location, commands);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("type", type);
            if (modifiers.HasValue)
            {
                dict.Add("modifiers", modifiers.Value);
            }

            if (timestamp.HasValue)
            {
                dict.Add("timestamp", timestamp.Value);
            }

            if (!(string.IsNullOrEmpty(text)))
            {
                dict.Add("text", text);
            }

            if (!(string.IsNullOrEmpty(unmodifiedText)))
            {
                dict.Add("unmodifiedText", unmodifiedText);
            }

            if (!(string.IsNullOrEmpty(keyIdentifier)))
            {
                dict.Add("keyIdentifier", keyIdentifier);
            }

            if (!(string.IsNullOrEmpty(code)))
            {
                dict.Add("code", code);
            }

            if (!(string.IsNullOrEmpty(key)))
            {
                dict.Add("key", key);
            }

            if (windowsVirtualKeyCode.HasValue)
            {
                dict.Add("windowsVirtualKeyCode", windowsVirtualKeyCode.Value);
            }

            if (nativeVirtualKeyCode.HasValue)
            {
                dict.Add("nativeVirtualKeyCode", nativeVirtualKeyCode.Value);
            }

            if (autoRepeat.HasValue)
            {
                dict.Add("autoRepeat", autoRepeat.Value);
            }

            if (isKeypad.HasValue)
            {
                dict.Add("isKeypad", isKeypad.Value);
            }

            if (isSystemKey.HasValue)
            {
                dict.Add("isSystemKey", isSystemKey.Value);
            }

            if (location.HasValue)
            {
                dict.Add("location", location.Value);
            }

            if ((commands) != (null))
            {
                dict.Add("commands", commands);
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.dispatchKeyEvent", dict);
            return methodResult;
        }

        partial void ValidateInsertText(string text);
        /// <summary>
        /// This method emulates inserting text that doesn't come from a key press,
        /// for example an emoji keyboard or an IME.
        /// </summary>
        /// <param name = "text">The text to insert.</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> InsertTextAsync(string text)
        {
            ValidateInsertText(text);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("text", text);
            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.insertText", dict);
            return methodResult;
        }

        partial void ValidateDispatchMouseEvent(string type, long x, long y, int? modifiers = null, long? timestamp = null, CefSharp.DevTools.Input.MouseButton? button = null, int? buttons = null, int? clickCount = null, long? deltaX = null, long? deltaY = null, string pointerType = null);
        /// <summary>
        /// Dispatches a mouse event to the page.
        /// </summary>
        /// <param name = "type">Type of the mouse event.</param>
        /// <param name = "x">X coordinate of the event relative to the main frame's viewport in CSS pixels.</param>
        /// <param name = "y">Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> DispatchMouseEventAsync(string type, long x, long y, int? modifiers = null, long? timestamp = null, CefSharp.DevTools.Input.MouseButton? button = null, int? buttons = null, int? clickCount = null, long? deltaX = null, long? deltaY = null, string pointerType = null)
        {
            ValidateDispatchMouseEvent(type, x, y, modifiers, timestamp, button, buttons, clickCount, deltaX, deltaY, pointerType);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("type", type);
            dict.Add("x", x);
            dict.Add("y", y);
            if (modifiers.HasValue)
            {
                dict.Add("modifiers", modifiers.Value);
            }

            if (timestamp.HasValue)
            {
                dict.Add("timestamp", timestamp.Value);
            }

            if (button.HasValue)
            {
                dict.Add("button", this.EnumToString(button));
            }

            if (buttons.HasValue)
            {
                dict.Add("buttons", buttons.Value);
            }

            if (clickCount.HasValue)
            {
                dict.Add("clickCount", clickCount.Value);
            }

            if (deltaX.HasValue)
            {
                dict.Add("deltaX", deltaX.Value);
            }

            if (deltaY.HasValue)
            {
                dict.Add("deltaY", deltaY.Value);
            }

            if (!(string.IsNullOrEmpty(pointerType)))
            {
                dict.Add("pointerType", pointerType);
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.dispatchMouseEvent", dict);
            return methodResult;
        }

        partial void ValidateDispatchTouchEvent(string type, System.Collections.Generic.IList<CefSharp.DevTools.Input.TouchPoint> touchPoints, int? modifiers = null, long? timestamp = null);
        /// <summary>
        /// Dispatches a touch event to the page.
        /// </summary>
        /// <param name = "type">Type of the touch event. TouchEnd and TouchCancel must not contain any touch points, while
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> DispatchTouchEventAsync(string type, System.Collections.Generic.IList<CefSharp.DevTools.Input.TouchPoint> touchPoints, int? modifiers = null, long? timestamp = null)
        {
            ValidateDispatchTouchEvent(type, touchPoints, modifiers, timestamp);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("type", type);
            dict.Add("touchPoints", touchPoints.Select(x => x.ToDictionary()));
            if (modifiers.HasValue)
            {
                dict.Add("modifiers", modifiers.Value);
            }

            if (timestamp.HasValue)
            {
                dict.Add("timestamp", timestamp.Value);
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.dispatchTouchEvent", dict);
            return methodResult;
        }

        partial void ValidateEmulateTouchFromMouseEvent(string type, int x, int y, CefSharp.DevTools.Input.MouseButton button, long? timestamp = null, long? deltaX = null, long? deltaY = null, int? modifiers = null, int? clickCount = null);
        /// <summary>
        /// Emulates touch event from the mouse event parameters.
        /// </summary>
        /// <param name = "type">Type of the mouse event.</param>
        /// <param name = "x">X coordinate of the mouse pointer in DIP.</param>
        /// <param name = "y">Y coordinate of the mouse pointer in DIP.</param>
        /// <param name = "button">Mouse button. Only "none", "left", "right" are supported.</param>
        /// <param name = "timestamp">Time at which the event occurred (default: current time).</param>
        /// <param name = "deltaX">X delta in DIP for mouse wheel event (default: 0).</param>
        /// <param name = "deltaY">Y delta in DIP for mouse wheel event (default: 0).</param>
        /// <param name = "modifiers">Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> EmulateTouchFromMouseEventAsync(string type, int x, int y, CefSharp.DevTools.Input.MouseButton button, long? timestamp = null, long? deltaX = null, long? deltaY = null, int? modifiers = null, int? clickCount = null)
        {
            ValidateEmulateTouchFromMouseEvent(type, x, y, button, timestamp, deltaX, deltaY, modifiers, clickCount);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("type", type);
            dict.Add("x", x);
            dict.Add("y", y);
            dict.Add("button", this.EnumToString(button));
            if (timestamp.HasValue)
            {
                dict.Add("timestamp", timestamp.Value);
            }

            if (deltaX.HasValue)
            {
                dict.Add("deltaX", deltaX.Value);
            }

            if (deltaY.HasValue)
            {
                dict.Add("deltaY", deltaY.Value);
            }

            if (modifiers.HasValue)
            {
                dict.Add("modifiers", modifiers.Value);
            }

            if (clickCount.HasValue)
            {
                dict.Add("clickCount", clickCount.Value);
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.emulateTouchFromMouseEvent", dict);
            return methodResult;
        }

        partial void ValidateSetIgnoreInputEvents(bool ignore);
        /// <summary>
        /// Ignores input events (useful while auditing page).
        /// </summary>
        /// <param name = "ignore">Ignores input events processing when set to true.</param>
        /// <returns>returns System.Threading.Tasks.Task&lt;DevToolsMethodResponse&gt;</returns>
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> SetIgnoreInputEventsAsync(bool ignore)
        {
            ValidateSetIgnoreInputEvents(ignore);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("ignore", ignore);
            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.setIgnoreInputEvents", dict);
            return methodResult;
        }

        partial void ValidateSynthesizePinchGesture(long x, long y, long scaleFactor, int? relativeSpeed = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null);
        /// <summary>
        /// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
        /// </summary>
        /// <param name = "x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "scaleFactor">Relative scale factor after zooming (&gt;1.0 zooms in, &lt;1.0 zooms out).</param>
        /// <param name = "relativeSpeed">Relative pointer speed in pixels per second (default: 800).</param>
        /// <param name = "gestureSourceType">Which type of input events to be generated (default: 'default', which queries the platform
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> SynthesizePinchGestureAsync(long x, long y, long scaleFactor, int? relativeSpeed = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null)
        {
            ValidateSynthesizePinchGesture(x, y, scaleFactor, relativeSpeed, gestureSourceType);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("x", x);
            dict.Add("y", y);
            dict.Add("scaleFactor", scaleFactor);
            if (relativeSpeed.HasValue)
            {
                dict.Add("relativeSpeed", relativeSpeed.Value);
            }

            if (gestureSourceType.HasValue)
            {
                dict.Add("gestureSourceType", this.EnumToString(gestureSourceType));
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.synthesizePinchGesture", dict);
            return methodResult;
        }

        partial void ValidateSynthesizeScrollGesture(long x, long y, long? xDistance = null, long? yDistance = null, long? xOverscroll = null, long? yOverscroll = null, bool? preventFling = null, int? speed = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null, int? repeatCount = null, int? repeatDelayMs = null, string interactionMarkerName = null);
        /// <summary>
        /// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
        /// </summary>
        /// <param name = "x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "xDistance">The distance to scroll along the X axis (positive to scroll left).</param>
        /// <param name = "yDistance">The distance to scroll along the Y axis (positive to scroll up).</param>
        /// <param name = "xOverscroll">The number of additional pixels to scroll back along the X axis, in addition to the given
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> SynthesizeScrollGestureAsync(long x, long y, long? xDistance = null, long? yDistance = null, long? xOverscroll = null, long? yOverscroll = null, bool? preventFling = null, int? speed = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null, int? repeatCount = null, int? repeatDelayMs = null, string interactionMarkerName = null)
        {
            ValidateSynthesizeScrollGesture(x, y, xDistance, yDistance, xOverscroll, yOverscroll, preventFling, speed, gestureSourceType, repeatCount, repeatDelayMs, interactionMarkerName);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("x", x);
            dict.Add("y", y);
            if (xDistance.HasValue)
            {
                dict.Add("xDistance", xDistance.Value);
            }

            if (yDistance.HasValue)
            {
                dict.Add("yDistance", yDistance.Value);
            }

            if (xOverscroll.HasValue)
            {
                dict.Add("xOverscroll", xOverscroll.Value);
            }

            if (yOverscroll.HasValue)
            {
                dict.Add("yOverscroll", yOverscroll.Value);
            }

            if (preventFling.HasValue)
            {
                dict.Add("preventFling", preventFling.Value);
            }

            if (speed.HasValue)
            {
                dict.Add("speed", speed.Value);
            }

            if (gestureSourceType.HasValue)
            {
                dict.Add("gestureSourceType", this.EnumToString(gestureSourceType));
            }

            if (repeatCount.HasValue)
            {
                dict.Add("repeatCount", repeatCount.Value);
            }

            if (repeatDelayMs.HasValue)
            {
                dict.Add("repeatDelayMs", repeatDelayMs.Value);
            }

            if (!(string.IsNullOrEmpty(interactionMarkerName)))
            {
                dict.Add("interactionMarkerName", interactionMarkerName);
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.synthesizeScrollGesture", dict);
            return methodResult;
        }

        partial void ValidateSynthesizeTapGesture(long x, long y, int? duration = null, int? tapCount = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null);
        /// <summary>
        /// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
        /// </summary>
        /// <param name = "x">X coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "y">Y coordinate of the start of the gesture in CSS pixels.</param>
        /// <param name = "duration">Duration between touchdown and touchup events in ms (default: 50).</param>
        /// <param name = "tapCount">Number of times to perform the tap (e.g. 2 for double tap, default: 1).</param>
        /// <param name = "gestureSourceType">Which type of input events to be generated (default: 'default', which queries the platform
        public async System.Threading.Tasks.Task<DevToolsMethodResponse> SynthesizeTapGestureAsync(long x, long y, int? duration = null, int? tapCount = null, CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null)
        {
            ValidateSynthesizeTapGesture(x, y, duration, tapCount, gestureSourceType);
            var dict = new System.Collections.Generic.Dictionary<string, object>();
            dict.Add("x", x);
            dict.Add("y", y);
            if (duration.HasValue)
            {
                dict.Add("duration", duration.Value);
            }

            if (tapCount.HasValue)
            {
                dict.Add("tapCount", tapCount.Value);
            }

            if (gestureSourceType.HasValue)
            {
                dict.Add("gestureSourceType", this.EnumToString(gestureSourceType));
            }

            var methodResult = await _client.ExecuteDevToolsMethodAsync("Input.synthesizeTapGesture", dict);
            return methodResult;
        }
    }
}