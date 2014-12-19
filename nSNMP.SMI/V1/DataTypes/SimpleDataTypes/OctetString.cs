﻿using System;
using System.Text;

namespace nSNMP.SMI.V1.DataTypes.SimpleDataTypes
{
    public class OctetString : SimpleDataType
    {
        public OctetString(byte[] data) : base(data)
        {
            SetDefaultEncoding();
        }

        public string Value
        {
            get
            {
                if (Encoding == null)
                {
                    throw new Exception();
                }

                return Encoding.GetString(Data, 0, Data.Length);
            }
        }

        public Encoding Encoding { get; set; }

        public void SetDefaultEncoding()
        {
            Encoding = Encoding.GetEncoding("ASCII");
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
