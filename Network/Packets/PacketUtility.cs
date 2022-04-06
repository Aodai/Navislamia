﻿using Navislamia.Network.Objects;
using Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Navislamia.Network.Packets
{
    public static class PacketUtility
    {
        public static string DumpToString(Packet packet)
        {
            string output = $"\nPrinting contents of: {packet.GetType().Name} ({packet.ID})\n\nChecksum: 0x{packet.Checksum.ToString("X2")}\n\n";

            try
            {
                foreach (var property in packet.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                {
                    string str = $"{property.Name}\n\n";
                    dynamic value = property.GetValue(packet);

                    if (value is byte[])
                        continue;

                    if (value is CString)
                    {
                        CString cVal = value as CString;

                        str += $"Simple: {cVal.String}\n\nDetailed:\n\n{Utilities.StringExt.ByteArrayToString(cVal.Data)}";
                    }
                    else
                    {
                        byte[] bVal = BitConverter.GetBytes(value);

                        str += $"Simple: {value}\n\nDetailed:\n{Utilities.StringExt.ByteArrayToString(bVal)}";
                    }

                    output += $"{str}\n";
                }
            }
            catch (Exception ex)
            {

            }

            return output;
        }

        public static uint GetLength(Packet packet)
        {
            uint length = 7;

            try
            {
                foreach (var property in packet.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance))
                {
                    var value = property.GetValue(packet);

                    if (value is byte[])
                        continue;

                    if (value is CString)
                        length += Convert.ToUInt32(((CString)value).Length);
                    else if (value is bool)
                        length += 1;
                    else
                        length += Convert.ToUInt32(Marshal.SizeOf(value));
                }
            }
            catch (Exception ex)
            {

            }

            return length;
        }
    }
}
