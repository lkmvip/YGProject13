using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class SymmetricMethod
{
	public string Key;

	private SymmetricAlgorithm mobjCryptoService;

	public SymmetricMethod()
	{
		this.mobjCryptoService = new RijndaelManaged();
		this.Key = "59NgzRLp67+myoJ9rXQpEctB3Hk439FocAdDGM89WAuztgT16KaYI1ApiI7Oqgbie6BWz";
	}

	public string Decrypto(string Source)
	{
		string end;
		try
		{
			byte[] numArray = Convert.FromBase64String(Source);
			MemoryStream memoryStream = new MemoryStream(numArray, 0, (int)numArray.Length);
			this.mobjCryptoService.Key = this.GetLegalKey();
			this.mobjCryptoService.IV = this.GetLegalIV();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, this.mobjCryptoService.CreateDecryptor(), CryptoStreamMode.Read);
			end = (new StreamReader(cryptoStream)).ReadToEnd();
		}
		catch
		{
			end = "";
		}
		return end;
	}

	public string Encrypto(string Source)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(Source);
		MemoryStream memoryStream = new MemoryStream();
		this.mobjCryptoService.Key = this.GetLegalKey();
		this.mobjCryptoService.IV = this.GetLegalIV();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, this.mobjCryptoService.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, (int)bytes.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	private byte[] GetLegalIV()
	{
		string str = "E4ghj*Ghg7!rNIfb&95GUY86GfghUb#er57HBh(u%g6HJ($jhWk7&!hg4ui%$hjk";
		this.mobjCryptoService.GenerateIV();
		int length = (int)this.mobjCryptoService.IV.Length;
		if (str.Length > length)
		{
			str = str.Substring(str.Length - length, length);
		}
		else if (str.Length < length)
		{
			str = str.PadRight(length, ' ');
		}
		return Encoding.ASCII.GetBytes(str);
	}

	private byte[] GetLegalKey()
	{
		string key = this.Key;
		this.mobjCryptoService.GenerateKey();
		int length = (int)this.mobjCryptoService.Key.Length;
		if (key.Length > length)
		{
			key = key.Substring(key.Length - length, length);
		}
		else if (key.Length < length)
		{
			key = key.PadRight(length, ' ');
		}
		return Encoding.ASCII.GetBytes(key);
	}
}