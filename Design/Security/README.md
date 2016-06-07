# Security discussion
There are several currently planned features that pose a security concern as a source of possible flaws and vulnerabilities.
So in this document I will discuss the main issues and possible solutions, as well as try to assess the risk they pose and if they perhaps should be avoided all together.

## Topics
* Client
  * RNA - Software interface accessed by the DNA
* Server
  * Communication with clients
  * Key management
* Update Manager
  * Verifying integrity of files
  * P2P distribution of updates and DNA
* Challenges
  * Logical bombs/Rogue scripts


## Client
### RNA

| Vulnerability           | Impact     | Likelihood | Risk        | Action                                          |
|-------------------------|------------|------------|-------------|-------------------------------------------------|
| Infinite loops          | Low 1      | High 3     | High 4      | Set time limit for task completion              |
| Extreme disk usage      | Low 1      | High 3     | High 4      | Cap read & writes/second and storage on disk    |
| Extreme memory usage    | Moderate 2 | High 3     | Very High 5 | Cap memory usage                                |
| Extreme CPU usage       | Moderate 2 | High 3     | Very High 5 | Cap CPU utilization and # of processes to spawn |
| Access other data       | High 3     | High 3     | Extreme 6   | Limit read/write to specific folders            |
| Spamming random servers | High 3     | High 3     | Extreme 6   | Limit network communication to specific IP      |
| Executing external CMDs | High 3     | High 3     | Extreme 6   | No access to commands other than RNA            |
(Initial version)

RNA must fail safe, if it discoveres any issues it must immediately terminate the process and if necessary upload DNA for analysis.
The testing of the RNA must be extremely thorough as any weaknesses or flaws will be discovered by the DNA.
It is imperitive that any flaws are found and patched pre-release.

Testing strategies:
  1. Documentation
  2. Architectual risk analysis (Model analysis)
  3. Threat modelling
  4. Static code analysis
  5. Code review
  6. Automated Testing Suite (ATS)
  7. Penetration testing
  8. dry-runs with resource monitoring
  
  
## Server
### Communication with clients

| Vulnerability         | Impact     | Likelihood | Risk        | Action                                  |
|-----------------------|------------|------------|-------------|-----------------------------------------|
| Injection             | High 3     | Moderate 2 | Very High 5 | Sanitize all input                      |
| Broken authentication | High 3     | Moderate 2 | Very High 5 | Authentication will be handled by oAuth |
| Components with Vulnerabilities | Moderate 2 | Moderate 2 | High 4 | Verify that all components are up-to-date |
| MFLAC*                | Moderate 2 | Moderate 2 | High 4      | Always verify authorization             |
| Session hijacking     | Moderate 2 | Unlikely 0 | Low 2       | Session time-out                        |

MFLAC: Missing Function Level Access Control

* To be written

### Key management
* To be written

## Update Manager
### Verifying integrity of files
* To be written

### P2P distribution
* To be written

## Challenges
### Logical bombs
* To be written
