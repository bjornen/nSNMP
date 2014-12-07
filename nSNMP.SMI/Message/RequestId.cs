﻿using nSNMP.SMI.V1.DataTypes.SimpleDataTypes;

namespace nSNMP.SMI.Message
{
    public class RequestId : Integer
    {
        public RequestId(SnmpDataType type, byte[] data) : base(data)
        {
        }
    }
}