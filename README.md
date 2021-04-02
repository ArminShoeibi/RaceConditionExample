# RaceConditionExample
Race Condition Example in C#, With Task Parallel Library.

## What is Race Condition ? 
1. A race condition occurs when two or more threads can access shared data and they try to change it at the same time. Because the thread scheduling algorithm can swap between threads at any time, you don't know the order in which the threads will attempt to access the shared data. Therefore, the result of the change in data is dependent on the thread scheduling algorithm, i.e. both threads are "racing" to access/change the data.

2. "race condition" exists when multithreaded (or otherwise parallel) code that would access a shared resource could do so in such a way as to cause unexpected results.

![Start](https://s16.picofile.com/file/8429393250/RaceCondition1.png)
![Mid1](https://s16.picofile.com/file/8429393276/RaceCondition2.png)
![Mid2](https://s16.picofile.com/file/8429393284/RaceCondition3.png)
![End](https://s16.picofile.com/file/8429393300/RaceCondition4.png)
