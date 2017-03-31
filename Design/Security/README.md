# Security discussion
There are several currently planned features that pose a security concern as a source of possible flaws and vulnerabilities.
So in this document I will discuss the main issues and possible solutions, as well as try to assess the risk they pose and if they perhaps should be avoided all together.

## Topics
* Client
  * RNA - Software interface accessed by the DNA
* Server
  * Communication with clients
* Update Manager
  * P2P distribution of updates and DNA
* Challenges
  * Logical bombs/Rogue scripts


## Client
### RNA

| Vulnerability            | Impact     | Likelihood | Risk        | Action                                          |
|--------------------------|------------|------------|-------------|-------------------------------------------------|
| Spamming the P2P network | High 3     | High 3     | Extreme 6   | Limit network communication to msg/min          |
| Access other data        | High 3     | High 3     | Extreme 6   | Limit read/write to specific folders            |
| Extreme CPU usage        | Moderate 2 | High 3     | Very High 5 | Cap # of concurrent DNAs to run                 |
| Extreme memory usage     | Moderate 2 | High 3     | Very High 5 | Cap memory usage & variable creation            |
| Extreme disk usage       | Low 1      | High 3     | High 4      | Cap read & writes/min and storage on disk       |
| Infinite loops           | Low 1      | High 3     | High 4      | Set time limit for task completion              |

RNA must fail safe, if it discoveres any issues it must immediately terminate the process and if necessary upload DNA for analysis.
The testing of the RNA must be extremely thorough as any weaknesses or flaws will be discovered by the DNA.
It is imperitive that any flaws are found and patched pre-release.

Testing strategies: (Initial thoughts, needs refining)
  1. Documentation
  2. Architectual risk analysis (Model analysis)
  3. Threat modelling
  4. Static code analysis
  5. Code review
  6. Automated Testing Suite (ATS)
  7. Penetration testing
  8. Dry-runs with resource monitoring
  
  
## Server
### Communication with clients

| Vulnerability         | Impact     | Likelihood | Risk        | Action                                  |
|-----------------------|------------|------------|-------------|-----------------------------------------|
| Injection             | High 3     | Moderate 2 | Very High 5 | Sanitize all input                      |
| Components with Vulnerabilities | Moderate 2 | Moderate 2 | High 4 | Verify that all components are up-to-date |
| Private key is stolen | High 3     | Unlikely 0 | Moderate 3  | See: Key management |

Communication, login and transfer of files/data will be handled by the [Hive2Hive library](https://github.com/Hive2Hive/Hive2Hive).
But we will still need to keep an eye on the higher-level communication protocols.

### Key management
I have currently planned the use of two keys:
1 key for assuring the authenticity of all update and data files from the server
1 key for assuring the authenticity of redistributed keys (replacing the update keys)

The update key will have a shorter life span as it will be used fairly frequently and as it's crucial to keep the chance of someone
being able to distribute malware updates to the minimum.

The key-authenticity key will have a longer life span as it is difficult to replace. One method of replacing it could be by requiring the user to manually download a new version of the client from the website, rather than using the P2P network.

## Update Manager
### P2P distribution
Currently I'm planning to utilize the P2P network to distribute updates to the clients.
This opens for some challanges, but here is the protocol as currently imagined:
1) Encrypt the update files and their associated hash-value using the private-update-authenticity key
2) Upload the update files and hash-values to the P2P network replacing the existing files with the new version. The files will be shared with all users as read-only.
3) This replacement will trigger a file-updated event in the client which will then download the latest version of the file along with the hash-value.
4) The client will decrypt the update files using the public-update-authenticity key
5) Then if the hash-value matches the decrypted files they will be considered safe and replace the existing files

These extra steps are to counter the off-chance that someone would be able to somehow steal the login-credentials to the server or exploit some unknown weakness in the Hive2Hive and upload false update files. Now they would also need the private keys which would be safely stored somewhere else.

I did consider options such as validating the generated update-hash with the server, but in the event that someone would be able to upload false files there is a chance they could have had access to the server which would render this check invalid.


## Challenges
### Tampered DNA
One challenge I have been thinking about for a while is how to keep people from writing their own DNA and submitting that to beat the current best DNA score. As far as I can tell this is nearly impossible to solve, perhaps appart from having the server generate all the DNAs which would defeat the purpose of this being a distributed project.
