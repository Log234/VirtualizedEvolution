# Virtualized Evolution
Virtualized Evolution is a software suite for creating a universe where software can develop it self based on evolution.

The evolution is based on challenges and rewards. The more challenges a program manages to complete, the higher score it gets, the higher is the chance that its DNA will be inherited down to the next generation.

The programs are developed based on the concept of DNA and RNA. Meaning that the code that is inherited and mutated between generations (the DNA) contains information on what to do. While the software interface that interprets the DNA (the RNA) contains information on how to do it. This means that the program can evolve naturally by changing its DNA, while we control what it can do by controlling the RNA.

This evolution is distributed.
All clients will be connected in a common cloud. From this cloud they may receive updates to their client, new huffman-tree compression data and they will send/receive DNA as they beat the current best DNA.
This way all clients can cooperate on developing the best possible DNA, utilizing the best DNA from their neighbours, while latencies in how the DNA is spread across the cloud allows for separate species to potentially evolve.



## Project Objectives
* Server - Not very different from a client, but is used to distribute updates, broadcast messages and monitor progress
* Client - Generates/evolves/tests/shares DNA
* Update Manager - Updates the client
* Automated Testing Suite - To reduce the chance of releasing broken builds

More information on the individual objectives in their respective folders.

## Project Security
There are several components of this project that will either require architecture rewrites, optimizations or thorough testing as they are vulnerable to security flaws or are open attack surfaces.
These issues will be discussed in [this document](https://github.com/Log234/VirtualizedEvolution/blob/master/Design/Security/README.md).
