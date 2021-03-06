﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Core
{
    public class CLGetPCList : Packet
    {
        public uint TimeStamp;

        public CLGetPCList(Stream stream)
        {
            // read size
            this.BodySize = ReadUInt32(stream);

            // read timestamp
            this.TimeStamp = ReadUInt32(stream);
        }

        public override void Write(ref NetworkStream stream)
        {

        }
    }
}
