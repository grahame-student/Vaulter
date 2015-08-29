/* 
 * Vaulter - Save Editor for the unpacked Fallout Shelter save files
 *
 * Copyright (C) 2015 Grahame White
 *
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*
* The full text of the license can be viewed at:
* http://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html
*
* Or in the LICENSE file
*/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FOSSaveData
{
	/// <summary>
	/// Description of Cypher.
	/// </summary>
	public class Cypher
	{
		private const int PHRASE_LENGTH = 8;
		private const int BUFFER_START = 0;
		
		private const string KEY  = "PlayerData";
		private const string SALT = "tu89geji340t89u2";
		
		private const int IV_LENGTH = 0x20;
		
		private const bool FOR_ENCRYPTING = true;
		private const bool FOR_DECRYPTING = false;
		
		public static string Decrypt(string encryptedData)
		{
			using (var decryptor = getDecryptor())
			{
				return getDecryptedString(getDecryptionBuffer(encryptedData), decryptor);
			}
		}
		
        private static ICryptoTransform getDecryptor()
        {
			byte[] salt = getSalt(FOR_DECRYPTING);
			byte[] iv = getIV(salt);
			
			return new RijndaelManaged { Mode = CipherMode.CBC }.CreateDecryptor(iv, salt);
        }
        
        private static byte[] getSalt(bool encrypt)
        {
        	return encrypt ? Encoding.UTF8.GetBytes(SALT) : Encoding.ASCII.GetBytes(SALT);
        }
        
        private static byte[] getIV(byte[] salt)
        {
        	return new Rfc2898DeriveBytes(getPassPhrase(), salt).GetBytes(IV_LENGTH);
        }
        
        private static string getPassPhrase()
        {
        	string str = KEY;
            
            while (str.Length < PHRASE_LENGTH)
            {
            	str += KEY;
            }
            
            return Base64Encode(str).Substring(BUFFER_START, PHRASE_LENGTH);
        }
        
        private static string Base64Encode(string plainText)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
        }
        
        private static byte[] getDecryptionBuffer(string encryptedData)
        {
        	return Convert.FromBase64String(encryptedData);
        }
        
		private static string getDecryptedString(byte[] encryptedData, ICryptoTransform decryptor)
		{
			using (var memoryStream = new MemoryStream(encryptedData))
			{
				using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
				{
					var buffer = new byte[encryptedData.Length];
					
					int count = cryptoStream.Read(buffer, BUFFER_START, buffer.Length);
					return Encoding.UTF8.GetString(buffer, BUFFER_START, count);
				}
			}
		}
		
        public static string Encrypt(string plainText)
        {
        	using (var encryptor = getEncryptor())
        	{
				return getEncryptedString(getEncryptionBuffer(plainText), encryptor);
        	}
        }
        
        private static ICryptoTransform getEncryptor()
        {
        	byte[] salt = getSalt(FOR_ENCRYPTING);
            byte[] iv = getIV(salt);
            
            return new RijndaelManaged { Mode = CipherMode.CBC }.CreateEncryptor(iv, salt);
        }
        
        private static byte[] getEncryptionBuffer(string plainText)
        {
	     	return Encoding.UTF8.GetBytes(plainText);
        }
        
        private static string getEncryptedString(byte[] plainText, ICryptoTransform encryptor)
        {
        	using (var memoryStream = new MemoryStream())
        	{
        		using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
        		{
		            cryptoStream.Write(plainText, BUFFER_START, plainText.Length);
		            cryptoStream.FlushFinalBlock();
		            
		            var buffer = memoryStream.ToArray();
		            
		            return Convert.ToBase64String(buffer);
        		}
        	}
        }
	}
}
