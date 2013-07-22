using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SignUp.Controllers
{
  class EncryptPassword
  {
    public String Encrypt(String password)
    {

      var md5 = MD5.Create();                                                  //create new instance of md5
      var hashData = md5.ComputeHash(Encoding.Default.GetBytes(password));    //convert the input text to array of bytes 
      var returnValue = new StringBuilder();                                 //create new instance of StringBuilder to save hashed data
      for (int i = 0; i < hashData.Length; i++)                             //loop for each byte and add it to StringBuilder
      {
        returnValue.Append(hashData[i].ToString());
      }
      return returnValue.ToString();                                // return hexadecimal string
    }
  }
}
