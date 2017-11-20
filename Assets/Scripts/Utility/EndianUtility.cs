using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Endian
{
	Little, Big
}
public static class EndianUtility {

	static byte[] Reverse(byte[] bytes, Endian endian)
	{
		if(BitConverter.IsLittleEndian ^ endian == Endian.Little)
			Array.Reverse(bytes) ;
		return bytes;
	}

	public static int ToInt32(byte[] value, int startIndex, Endian endian)
	{
		byte[] sub = GetSubArray(value, startIndex, sizeof(int));
		return BitConverter.ToInt32(Reverse(sub, endian), 0);
	}

	// バイト配列から一部分を抜き出す
	static byte[] GetSubArray(byte[] src, int startIndex, int count)
	{
		byte[] dst = new byte[count];
		Array.Copy(src, startIndex, dst, 0, count);
		return dst;
	}
}
