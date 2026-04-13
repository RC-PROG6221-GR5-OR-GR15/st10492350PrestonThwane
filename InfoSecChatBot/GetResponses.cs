class GetResponse
{   
public static string GetResponseMessage(string input)
    {
        input = input.ToLower();
        input = input.ToLower().Trim(new char[] { '.', '?', '!' });

        if (input.Contains("phishing"))
            return "Phishing is a cyber attack where attackers trick users into revealing sensitive info.";
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
        else if (input.Contains("DDoS"))
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
        else if (input.Contains("What is your purpose") || input.Contains("What is your mission"))
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
        else if (input.Contains("two-factor authentication") || input.Contains("2FA"))
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
        else if (input.Contains("identity and access management") || input.Contains("IAM"))            
            return "Identity and Access Management (IAM) is a framework of policies and technologies for ensuring that the right individuals have access to the right resources at the right times for the right reasons.";
        else if (input.Contains("CIA triad") || input.Contains("confidentiality integrity availability") || input.Contains("cia"))
            return "The CIA triad is a model for information security that stands for Confidentiality, Integrity, and Availability.";
        else
            return "Sorry, I don't have information on that topic. Please ask about another Information Security topic.";
    }
}