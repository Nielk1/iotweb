﻿namespace IotWeb_CarbyneFork.Common.Http
{
    public interface IWebSocketRequestHandler
    {
        bool WillAcceptRequest(string uri, string protocol);

		void Connected(WebSocket socket);
    }
}
