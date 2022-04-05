﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Packets
{
    public interface ISerializablePacket
    {
        public void Serialize();

        public void Deserialize(byte[] data);
    }
}