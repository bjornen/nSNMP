﻿
namespace nSNMP.SMI.PDUs
{
    public class GetResponse : PDU
    {
        private GetResponse(byte[] data) : base(data)
        {
        }

        public GetResponse()
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