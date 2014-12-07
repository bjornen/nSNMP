﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nSNMP.SMI
{
    public enum SnmpDataType
    {
        //Primitive V1
        Integer = 0x02,
        OctetString = 0x04,
        Null = 0x05,
        ObjectIdentifier = 0x06,
        
        //Constructed V1
        Sequence = 0x30,
        GetRequestPDU = 0xA0,
        GetResponsePDU = 0xA2,
        SetRequestPDU = 0xA3,
    }

    //public enum SnmpDataTypes // RFC1213 subset of ASN.1
    //{
    //    EndMarker = 0x00,

    //    /// <summary>
    //    /// INTEGER type. (SMIv1, SMIv2)
    //    /// </summary>
    //    Integer32 = 0x02,

    //    /// <summary>
    //    /// OCTET STRING type.
    //    /// </summary>
    //    OctetString = 0x04, // X690.OctetString

    //    /// <summary>
    //    /// NULL type. (SMIv1)
    //    /// </summary>
    //    Null = 0x05,

    //    /// <summary>
    //    /// OBJECT IDENTIFIER type. (SMIv1)
    //    /// </summary>
    //    ObjectIdentifier = 0x06,

    //    /// <summary>
    //    /// RFC1213 sequence for whole SNMP packet beginning
    //    /// </summary>
    //    Sequence = 0x30,  // RFC1213 sequence for whole SNMP packet beginning

    //    /// <summary>
    //    /// IpAddress type. (SMIv1)
    //    /// </summary>
    //    IPAddress = 0x40,

    //    /// <summary>
    //    /// Counter32 type. (SMIv1, SMIv2)
    //    /// </summary>
    //    Counter32 = 0x41,

    //    /// <summary>
    //    /// Gauge32 type. (SMIv1, SMIv2)
    //    /// </summary>
    //    Gauge32 = 0x42,

    //    /// <summary>
    //    /// TimeTicks type. (SMIv1)
    //    /// </summary>
    //    TimeTicks = 0x43,

    //    /// <summary>
    //    /// Opaque type. (SMIv1)
    //    /// </summary>
    //    Opaque = 0x44,

    //    /// <summary>
    //    /// Network Address. (SMIv1)
    //    /// </summary>
    //    NetAddress = 0x45,

    //    /// <summary>
    //    /// Counter64 type. (SMIv2)
    //    /// </summary>
    //    Counter64 = 0x46,

    //    /// <summary>
    //    /// No such object exception.
    //    /// </summary>
    //    NoSuchObject = 0x80,

    //    /// <summary>
    //    /// No such instance exception.
    //    /// </summary>
    //    NoSuchInstance = 0x81,

    //    /// <summary>
    //    /// End of MIB view exception.
    //    /// </summary>
    //    EndOfMibView = 0x82,

    //    /// <summary>
    //    /// Get request PDU.
    //    /// </summary>
    //    GetRequestPdu = 0xA0,

    //    /// <summary>
    //    /// Get Next request PDU.
    //    /// </summary>
    //    GetNextRequestPdu = 0xA1,

    //    /// <summary>
    //    /// Response PDU.
    //    /// </summary>
    //    ResponsePdu = 0xA2,

    //    /// <summary>
    //    /// Set request PDU.
    //    /// </summary>
    //    SetRequestPdu = 0xA3,

    //    /// <summary>
    //    /// Trap v1 PDU.
    //    /// </summary>
    //    TrapV1Pdu = 0xA4,

    //    /// <summary>
    //    /// Get Bulk PDU.
    //    /// </summary>
    //    GetBulkRequestPdu = 0xA5,

    //    /// <summary>
    //    /// Inform PDU.
    //    /// </summary>
    //    InformRequestPdu = 0xA6,

    //    /// <summary>
    //    /// Trap v2 PDU.
    //    /// </summary>
    //    TrapV2Pdu = 0xA7,

    //    /// <summary>
    //    /// Report PDU. SNMP v3.
    //    /// </summary>
    //    ReportPdu = 0xA8,

    //    /// <summary>
    //    /// Defined by #SNMP for unknown type.
    //    /// </summary>
    //    Unknown = 0xFFFF
    //}
}
