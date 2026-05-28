class GetResponse
{
   
    private static string lastTopic = "";
    private static string userName = "";
    private static string favouriteTopic = "";
    private static string lastSentiment = "";

    public static string GetResponseMessage(string input)
    {
        input = input.ToLower();
        input = input.ToLower().Trim(new char[] { '.', '?', '!' });
    
        // Sentiment Detection Section
        if (input.Contains("sad") || input.Contains("upset") || input.Contains("angry") || input.Contains("frustrated") || input.Contains("deperessed"))
        {
            lastSentiment = "negative";
            return $"I'm sorry to hear that, {userName}. Cybersecurity can be stressful sometimes.";
        }
        else if (input.Contains("happy") || input.Contains("great") || input.Contains("good") || input.Contains("excited") || input.Contains("joyful"))
        {
            lastSentiment = "positive";
            return $"That’s wonderful to hear, {userName}! Keeping a positive mindset helps you stay alert and safe online.";
        }
        else if (input.Contains("ok") || input.Contains("fine") || input.Contains("neutral"))
        {
            lastSentiment = "neutral";
            return $"Got it, {userName}. Let’s keep learning about cybersecurity together.";
        }

        //Conversational Flow Section
        if (input.Contains("tell me more") || input.Contains("explain more") || input.Contains("give another tip"))
        {
            if (string.IsNullOrEmpty(lastTopic))
                return "We haven’t discussed a topic yet. Ask me about something like phishing or password safety!";
            else
                return ElaborateOnTopic(lastTopic);
        }
        // Beginning of Conversational Flow Section

        // Memory and Recall Section
        if (input.StartsWith("my name is"))
        {
            userName = input.Replace("my name is", "").Trim();
            return $"Nice to meet you, {userName}! I’ll remember your name for our chat.";
        }
        else if (input.StartsWith("my favourite topic is"))
        {
            favouriteTopic = input.Replace("my favourite topic is", "").Trim();
            return $"Got it! I’ll remember that your favourite topic is {favouriteTopic}.";
        }
        else if (input.Contains("what is my name"))
        {
            if (string.IsNullOrEmpty(userName))
                return "I don’t think you’ve told me your name yet.";
            else
                return $"Your name is {userName}.";
        }
        else if (input.Contains("what is my favourite topic"))
        {
            if (string.IsNullOrEmpty(favouriteTopic))
                return "You haven’t mentioned your favourite topic yet.";
            else
                return $"Your favourite topic is {favouriteTopic}.";
        }
        // End of Memory and Recall Section

        if (input.Contains("password"))
        {
            lastTopic = "password";
            return "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords.";
        }
        else if (input.Contains("scam"))
        {
            lastTopic = "scam";
            return "Be cautious of unsolicited messages or links. Verify sources before sharing information to avoid scams.";
        }
        else if (input.Contains("privacy"))
        {
            lastTopic = "privacy";
            return "Protect your privacy by limiting what you share online and reviewing app permissions regularly.";
        }
        else if (input.Contains("phishing"))
        {
            lastTopic = "phishing";
            return "Phishing is a cyber attack where attackers trick users into revealing sensitive info.";
        }
        else if (input.Contains("encryption"))
            return "Encryption is the process of converting data into a coded format to prevent unauthorized access.";
        else if (input.Contains("firewall"))
            return "A firewall is a network security device that monitors and controls incoming and outgoing network traffic.";
        else if (input.Contains("malware"))
            return "Malware is malicious software designed to harm, exploit, or otherwise compromise a computer system.";
        else if (input.Contains("ransomware"))
            return "Ransomware is a type of malware that encrypts a victim's files and demands payment for the decryption key.";
        else if (input.Contains("social engineering"))
            return "Social engineering is a manipulation technique that exploits human error to gain private information.";
        else if (input.Contains("Bums"))
            return "Yes Baba has very nice small jiggly bums";
        else if (input.Contains("ddos"))
            return "DDoS (Distributed Denial of Service) is an attack where multiple compromised systems flood a target with traffic.";
        else if (input.Contains("cybersecurity"))
            return "Cybersecurity is the practice of protecting systems, networks, and data from digital attacks.";
        else if (input.Contains("how are you") || input.Contains("how are you doing"))
            return "I'm doing well and feeling secure, thank you for asking! How can I assist you with Information Security topics today?";
        else if (input.Contains("what is your name") || input.Contains("who are you"))
            return "My name is Cynthia, and I'm a Bot here to help you with Information Security topics. What would you like to know?";
        else if (input.Contains("what can you do") || input.Contains("what are your capabilities"))
            return "I can provide information on various Information Security topics such as phishing, encryption, firewalls, malware, and more. Just ask me about any topic you're interested in!";
        else if (input.Contains("cyber hygiene"))
            return "Cyber hygiene refers to the practices and steps that users of computers and other devices take to maintain system health and improve online security.";
        else if (input.Contains("threat intelligence"))
            return "Threat intelligence is the information that organizations use to understand the threats that have, will, or are currently targeting them.";
        else if (input.Contains("what is your purpose") || input.Contains("what is your mission"))
            return "My purpose is to provide information and answer questions about Information Security topics to help users understand and improve their cybersecurity knowledge.";
        else if (input.Contains("password management"))
            return "Password management involves creating, storing, and using strong passwords to protect accounts and sensitive information.";
        else if (input.Contains("safe browsing"))
            return "Safe browsing is the practice of using the internet in a way that minimizes the risk of encountering malicious websites and content.";
        else if (input.Contains("data privacy"))
            return "Data privacy is the aspect of information technology that deals with the ability of an individual or organization to control how their personal information is collected and used.";
        else if (input.Contains("why is the sky blue"))
            return "The sky appears blue due to the scattering of sunlight by the Earth's atmosphere, which is more effective at scattering shorter wavelengths of light (blue) than longer wavelengths (red).";
        else if (input.Contains("what is information security") || input.Contains("what is infosec"))
            return "Information security, often abbreviated as InfoSec, is the practice of protecting information by mitigating information risks and vulnerabilities.";
        else if (input.Contains("vulnerability"))
            return "A vulnerability is a weakness in a system that can be exploited by attackers to gain unauthorized access.";
        else if (input.Contains("patching"))
            return "Patching is the process of applying updates to software to fix vulnerabilities and improve security.";
        else if (input.Contains("two-factor authentication") || input.Contains("2fa"))
            return "Two-factor authentication (2FA) adds an extra layer of security by requiring two forms of verification.";
        else if (input.Contains("zero-day"))
            return "A zero-day vulnerability is a security flaw that is unknown to the software vendor and can be exploited by attackers.";
        else if (input.Contains("penetration testing") || input.Contains("pentesting"))
            return "Penetration testing is a simulated cyber attack against a system to identify vulnerabilities.";
        else if (input.Contains("security awareness training"))
            return "Security awareness training educates employees about cybersecurity best practices and how to recognize threats.";
        else if (input.Contains("incident response"))
            return "Incident response is the process of handling and managing the aftermath of a security breach or cyber attack.";
        else if (input.Contains("data breach"))
            return "A data breach is an incident where sensitive, protected, or confidential data is accessed or disclosed without authorization.";
        else if (input.Contains("cyber attack"))
            return "A cyber attack is an attempt to damage, disrupt, or gain unauthorized access to computer systems, networks, or data.";
        else if (input.Contains("vulnerability assessment"))
            return "A vulnerability assessment is the process of identifying, quantifying, and prioritizing vulnerabilities in a system.";
        else if (input.Contains("security policy"))
            return "A security policy is a set of rules and practices that specify how an organization manages and protects its information assets.";
        else if (input.Contains("access control"))
            return "Access control is a security technique that regulates who or what can view or use resources in a computing environment.";
        else if (input.Contains("data encryption"))
            return "Data encryption is the process of converting data into a coded format to prevent unauthorized access.";
        else if (input.Contains("network security"))
            return "Network security is the practice of protecting a computer network from unauthorized access, misuse, or theft.";
        else if (input.Contains("endpoint security"))
            return "Endpoint security is the practice of securing endpoints or entry points of end-user devices such as desktops, laptops, and mobile devices from being exploited by malicious actors.";
        else if (input.Contains("cloud security"))
            return "Cloud security is the set of policies, technologies, and controls deployed to protect data, applications, and infrastructure associated with cloud computing.";
        else if (input.Contains("identity and access management") || input.Contains("iam"))
            return "Identity and Access Management (IAM) is a framework of policies and technologies for ensuring that the right individuals have access to the right resources at the right times for the right reasons.";
        else if (input.Contains("cia triad") || input.Contains("confidentiality integrity availability") || input.Contains("cia"))
            return "The CIA triad is a model for information security that stands for Confidentiality, Integrity, and Availability.";
        else
        {
            lastTopic = "";
            return "Sorry, I don't have information on that topic. Please ask about another Information Security topic.";
        }
    }

    //Helper Method for Elaboration
    private static string ElaborateOnTopic(string topic)
    {
        switch (topic)
        {
            case "password":
                return "Strong passwords combine letters, numbers, and symbols. Using a password manager helps you store them securely and avoid reuse.";
            case "scam":
                return "Scams often rely on urgency or emotional manipulation. Always double-check sender details and never share personal info via email.";
            case "privacy":
                return "Privacy protection means controlling who accesses your data. Review social media settings and use encrypted messaging apps.";
            case "phishing":
                return "Phishing attempts often use spoofed sender addresses and urgent language. Verify links and attachments before interacting and check for subtle domain differences.";
            // add more cases as needed
            default:
                return "I don't have an elaboration for that topic... Try common basic human brain power understanding? :)...";
        }
    }
}