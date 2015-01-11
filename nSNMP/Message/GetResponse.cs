﻿namespace nSNMP.Message
{
    public class GetResponse : Pdu
    {
        private GetResponse(byte[] data) : base(data)
        {
        }

        public GetResponse() : base(null)
        {
            
        }

        public static GetResponse Create(byte[] data)
        {
            var pdu = new GetResponse(data);

            pdu.Initialize();

            return pdu;
        }
    }
}