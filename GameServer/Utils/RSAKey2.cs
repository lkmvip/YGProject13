using ns7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ns12
{
	internal class RSAKey2
	{
		private string string_0 = "<RSAKeyValue><Modulus>9PVgT9/BP1olVjznLgyjiSyV0fMkumBccyzQLBEg7A9Wn8X/SysY4SRvaZhXCQ811yCxIjTOaUTpVZsd64I5naeVIjoGvyqxe7ZRcWjMYe5ZxIb5fNrISPHhkGQNNn1N/UMzYJzHymqJOZGrQOpc4Pai7Aqmo8eNsPYC9HYnJz0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

		public RSAKey2()
		{
		}

		public string method_0(string string_1)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(this.string_0);
			RSAParameters rSAParameter = rSACryptoServiceProvider.ExportParameters(false);
			byte[] modulus = rSAParameter.Modulus;
			byte[] exponent = rSAParameter.Exponent;
			BigInteger bigInteger = new BigInteger(modulus);
			BigInteger bigInteger1 = new BigInteger(exponent);
			byte[] bytes = Encoding.UTF8.GetBytes(string_1);
			int num = 86;
			int length = (int)bytes.Length;
			int num1 = length / 86;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i <= num1; i++)
			{
				byte[] numArray = new byte[(length - num * i > num ? num : length - num * i)];
				Buffer.BlockCopy(bytes, num * i, numArray, 0, (int)numArray.Length);
				byte[] numArray1 = this.method_2(numArray, bigInteger1, bigInteger);
				Array.Reverse(numArray1);
				stringBuilder.Append(Convert.ToBase64String(numArray1));
			}
			return stringBuilder.ToString();
		}

		public string method_1(string string_1)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(this.string_0);
			RSAParameters rSAParameter = rSACryptoServiceProvider.ExportParameters(false);
			byte[] modulus = rSAParameter.Modulus;
			byte[] exponent = rSAParameter.Exponent;
			BigInteger bigInteger = new BigInteger(modulus);
			BigInteger bigInteger1 = new BigInteger(exponent);
			int num = 172;
			int length = string_1.Length / 172;
			ArrayList arrayLists = new ArrayList();
			for (int i = 0; i < length; i++)
			{
				byte[] numArray = Convert.FromBase64String(string_1.Substring(num * i, num));
				Array.Reverse(numArray);
				arrayLists.AddRange(this.method_3(numArray, bigInteger1, bigInteger));
			}
			return Encoding.UTF8.GetString(arrayLists.ToArray(Type.GetType("System.Byte")) as byte[]);
		}

		private byte[] method_2(byte[] byte_0, BigInteger class117_0, BigInteger class117_1)
		{
			int length = (int)byte_0.Length;
			int num = 0;
			int num1 = 0;
			num = (length % 120 != 0 ? length / 120 + 1 : length / 120);
			List<byte> nums = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				num1 = (length < 120 ? length : 120);
				byte[] numArray = new byte[num1];
				Array.Copy(byte_0, i * 120, numArray, 0, num1);
				Encoding.UTF8.GetString(numArray);
				string str = (new BigInteger(numArray)).method_5(class117_0, class117_1).method_4();
				if (str.Length < 256)
				{
					while (str.Length != 256)
					{
						str = string.Concat("0", str);
					}
				}
				byte[] numArray1 = new byte[128];
				for (int j = 0; j < (int)numArray1.Length; j++)
				{
					numArray1[j] = Convert.ToByte(str.Substring(j * 2, 2), 16);
				}
				nums.AddRange(numArray1);
				length = length - num1;
			}
			return nums.ToArray();
		}

		private byte[] method_3(byte[] byte_0, BigInteger class117_0, BigInteger class117_1)
		{
			int length = (int)byte_0.Length;
			int num = 0;
			int num1 = 0;
			num = (length % 128 != 0 ? length / 128 + 1 : length / 128);
			List<byte> nums = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				num1 = (length < 128 ? length : 128);
				byte[] numArray = new byte[num1];
				Array.Copy(byte_0, i * 128, numArray, 0, num1);
				byte[] numArray1 = (new BigInteger(numArray)).method_5(class117_0, class117_1).method_21();
				Encoding.UTF8.GetString(numArray1);
				nums.AddRange(numArray1);
				length = length - num1;
			}
			return nums.ToArray();
		}
	}
}