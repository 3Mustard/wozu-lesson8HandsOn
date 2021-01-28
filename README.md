# wozu-lesson8HandsOn

# Part 1

Create an interface named Mammal that includes the following methods:
speak(): It should print to the console the sound made by the animal.
run(): It should print to the console the top speed at which the animal can run.
Create three classes — Dog, Cat, and Cow — which implement the Mammal interface. Below is a list of print statements that should be made for each mammal's speak() and run() method:
speak() list:
Dog: "Bark!"
Cat: "Meow!"
Cow: "Moo!
run() list:
Dog: "Dogs can run at a top speed of 45 mph!"
Cat: "Cats can run at a top speed of 30 mph!"
Cow: "Cows can run at a top speed of 25 mph!"
In the Main method, instantiate new objects for a Dog, Cat, and Cow.
Finally, call the speak() and run() methods on each object.
The output will look like the following:
```
Bark!
Dogs can run at a top speed of 45 mph!
Meow!
Cats can run at a top speed of 30 mph!
Moo!
Cows can run at a top speed of 25 mph!
```

# Part 2

Create a new interface called Animal that contains a method called eat(), which will print out the favorite food for that animal.
Update the Mammal interface to extend from the Animal interface.
Update the classes that implement the Mammal interface to use the eat() method. The list of eat() responses for each animal is listed below:
Dog: "Dogs eat bones."
Cat: "Cats eat mice."
Cow: "Cows eat grass."
In the Main method, call the eat() method on the Dog, Cat, and Cow objects.
Your output will look like the following:
```
Bark!
Dogs can run at a top speed of 45 mph!
Dogs eat bones.
Meow!
Cats can run at a top speed of 30 mph!
Cats eat mice.
Moo!
Cows can run at a top speed of 25 mph!
Cows eat grass.
```
