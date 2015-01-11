﻿using System;
using System.Text;

namespace nSNMP.SMI.DataTypes.V1.Primitive
{
    public class OctetString : PrimitiveDataType
    {
        public OctetString(byte[] data) : base(data)
        {
            SetDefaultEncoding();
        }

        public static OctetString Create(string content)
        {
            var encoding = Encoding.GetEncoding("ASCII");
            
            byte[] data = encoding.GetBytes(content);

            return new OctetString(data);
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
