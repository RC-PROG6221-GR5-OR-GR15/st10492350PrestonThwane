using System;
using System.Drawing;
using System.Windows.Forms;

public class ChatForm : Form
{
    private TextBox inputBox;
    private Button sendButton;
    private TextBox chatBox;
    private Label titleLabel;

    public ChatForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        this.Text = "InfoSec ChatBot - Cynthia";
        this.Size = new Size(700, 500);
        this.StartPosition = FormStartPosition.CenterScreen;

        titleLabel = new Label();
        titleLabel.Text = "InfoSec ChatBot - Cynthia";
        titleLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        titleLabel.Location = new Point(10, 10);
        titleLabel.AutoSize = true;
        this.Controls.Add(titleLabel);

        chatBox = new TextBox();
        chatBox.Multiline = true;
        chatBox.ReadOnly = true;
        chatBox.ScrollBars = ScrollBars.Vertical;
        chatBox.Location = new Point(10, 40);
        chatBox.Size = new Size(660, 360);
        chatBox.BackColor = Color.White;
        chatBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.Controls.Add(chatBox);

        inputBox = new TextBox();
        inputBox.Location = new Point(10, 410);
        inputBox.Size = new Size(560, 30);
        inputBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        inputBox.KeyDown += InputBox_KeyDown;
        this.Controls.Add(inputBox);

        sendButton = new Button();
        sendButton.Text = "Send";
        sendButton.Location = new Point(580, 408);
        sendButton.Size = new Size(90, 32);
        sendButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        sendButton.Click += SendButton_Click;
        this.Controls.Add(sendButton);

        // Welcome message
        AppendBotMessage("Hello! I am Cynthia, your Information Security assistant. Ask me about infosec topics.");
    }

    private void InputBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            SendCurrentMessage();
        }
    }

    private void SendButton_Click(object sender, EventArgs e)
    {
        SendCurrentMessage();
    }

    private void SendCurrentMessage()
    {
        var text = inputBox.Text?.Trim();
        if (string.IsNullOrEmpty(text))
            return;

        AppendUserMessage(text);
        var response = GetResponse.GetResponseMessage(text);
        AppendBotMessage(response);
        inputBox.Clear();
    }

    private void AppendUserMessage(string message)
    {
        chatBox.AppendText($"You: {message}{Environment.NewLine}");
    }

    private void AppendBotMessage(string message)
    {
        chatBox.AppendText($"Cynthia: {message}{Environment.NewLine}");
    }
}
