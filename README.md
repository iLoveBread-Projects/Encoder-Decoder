# Encoder-Decoder

### *What is it?*
> It is an open source decoder and encoder built in one application. **The code is written in C#**

### *How to install*
> If you want to install the full project, then download the full repository and open the [EncoderDecoder.sln](https://github.com/iLoveBread-Code/Encoder-Decoder/blob/main/EncoderDecoder.sln) file in Visual Studio Community.
> 
> If you want to download the application only, [click here](https://github.com/iLoveBread-Code/Encoder-Decoder/raw/main/EncoderDecoder/bin/Release/EncoderDecoder.exe)

### *How to use the generator*
1. Input a text in the first text box.
2. * Press *Encode* to convert your text to a hidden message.
   * Press *Decode* to covnert your hidden message to text.
3. Copy your hidden message or text by clicking the *Copy* button.

### *Explaining the code*
> The main code is in the [Form1.cs](https://github.com/iLoveBread-Code/Encoder-Decoder/blob/main/EncoderDecoder/Form1.cs) file. You can follow along there if you want to know how the generator was made.

<details><summary>Creation of the EncodeServerName string</summary>

```chsarp
public static string EncodeServerName(string serverName)
{
    return Convert.ToBase64String(Encoding.UTF8.GetBytes(serverName));
}
```

</details>

<details><summary>Creation of the DecodeServerName string</summary>

```chsarp
public static string DecodeServerName(string encodedServername)
{
    return Encoding.UTF8.GetString(Convert.FromBase64String(encodedServername));
}
```

</details>

<details><summary>The event when the Encode button is clicked</summary>

```chsarp
        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string encode = EncodeServerName(txtText.Text);

                txtResult.Text = encode;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not encode the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
```

</details>

<details><summary>The event when the Decode button is clicked</summary>

```chsarp
        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string decode = DecodeServerName(txtText.Text);

                txtResult.Text = decode;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not decode the message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
```

</details>

#### *Enjoy the Encoder/Decoder application*
