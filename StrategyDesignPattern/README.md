Strategy DesignPattern

Behavioral design pattern

The Strategy design pattern is a behavioral design pattern that allows us to define different functionalities, put each functionality in a separate class and make their objects interchangeable.

In other words, we have a main Context object that holds a reference towards a Strategy object and delegates it by executing its functionality. If we want to change the way the Context performs its work, we can just replace the current Strategy object with another one.

We should use this pattern whenever we have different variations for some functionality in an object and we want to switch from one variation to another in a runtime. 
Furthermore, if we have similar classes in our project that only differ on how they execute some behavior, the Strategy pattern should be the right choice for us.

We should consider introducing this pattern in situations where a single class has multiple conditions over different variations of the same functionality. 
That’s because the Strategy pattern lets us extract those variations into separate classes (concrete strategies). Then we can invoke them into the context class.


