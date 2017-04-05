
# Tasks

The tasks are the nutrition of the DNA, they will award the DNA a certain amount of points and extend its lifespan by a certain amount, depending on the complexity of the task.

## Task types
There will be a number of different types of tasks, and the type says something about the task complexity.

### Math
Math tasks will consist of some mathematical problem the DNA needs to solve.

There will be tasks with simple basic math, equations, etc. If the DNA gave a wrong answer the correct answer will be revealed for it.
I suggest we write both static and dynamic tasks, static tasks will have the same problem to solve and same answer every single run, but dynamic tasks will contain variables who's values will be changed for each run, making it impossible to simply remember the previously correct answer.

Maybe we also could write some task that will generate valid problems to solve with known answers. This could give the DNA the opportunity to learn math by solving a huge number of different equations.

### Text
Text tasks will consist of some query to be answered.
We should consider whether to reveal the "correct answer" or not, as this is a question I feel is up for debate.
Both static and dynamic tasks could be implemented here as well.

These tasks may be difficult to formulate, as the correct answer may be difficult to validate.
Here are some suggestions:

(Fairly simple tasks, requires no knowledge of grammar or semantics, only an expected word given a context)  
Task: "Hello"  
Answer: "Hello" or "Hey" or "Hi" or "Howdy" or "Hello, world!" or ...

(Bit more advanced, requires no understanding of semantics, but does require an understanding of grammar)  
Task: "This is my ball." "This ball is x."  
Answer: "mine"

(Very advanced, requires an understanding of semantics)  
Task: "Paul is feeling happy." "Is Paul happy?"  
Answer: "Yes" or True

Another option is allowing the user and DNA to communicate through the console, that way the user can reward the DNA for behaving in a positive/expected manner. This allows for a more advanced and precise development, as the DNA can only become as smart as the tasks we give it.

### Visual
These tasks will be planned later

### Audio
These tasks will be blanned later
