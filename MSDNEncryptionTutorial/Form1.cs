using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSDNEncryptionTutorial
{
    public partial class btnImportPublicKey : Form
    {
        //declare CspParameters and RsaCryptoServiceProvider objects with global scope.
        CspParameters cspp = new CspParameters();
        RSACryptoServiceProvider rsa;

        //path variables for source, encryption and decryption folders.
        //MUST end with a backslash
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        const string SrcFolder = @"c:\docs\";

        //public key file
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        public btnImportPublicKey()
        {
            InitializeComponent();
        }
    }
}
