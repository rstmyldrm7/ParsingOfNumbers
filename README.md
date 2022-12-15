# ParsingOfNumbers

Hi,

This program allows you to parse the numbers of written with text in a sentences to their numeric value.

I will explain with two steps, program side and the test side.

Here is the structure of the app.

![image](https://user-images.githubusercontent.com/59121690/207815946-d575f033-cae7-45a0-997d-bade10bbc4ce.png)

--- PROGRAM SIDE ---

In the program.cs i get the sentence in a string value and sending it to IParseService interface to parse text. 

![image](https://user-images.githubusercontent.com/59121690/207816403-7b801882-aa81-4551-b3a3-33e6c2fd3778.png)

Here in ParseService i seperate the words with help of my DictionaryHelper and sending them to my Regex code to make them an numeric value inside of an sentence. I am
understanding a difference of an word if that is a numeric text or an normal word within help of my DictionaryClass that i declared inside of my DictionaryHelper.

![image](https://user-images.githubusercontent.com/59121690/207816943-e8be38d1-8bac-4d3b-8e39-993b6b0676ac.png)

My dictionaryClass generator

![image](https://user-images.githubusercontent.com/59121690/207817063-ea7949ee-b688-45a4-8eff-72ef2408ce06.png)

Sentence splitter

![image](https://user-images.githubusercontent.com/59121690/207817105-ec2bd5da-bbe1-4300-b599-da4c02842435.png)

Text Parsing Helper

![image](https://user-images.githubusercontent.com/59121690/207817148-5bd3d433-0196-441f-ab2b-8c4d8abafc3b.png)


--- TEST SIDE ---

I used XUnit for unit testing.

Here is my Code Coverage

![image](https://user-images.githubusercontent.com/59121690/207817524-a4bdbf89-1efa-47ab-9592-6a3c6443028f.png)

I designed test for generating random numbers and convert them to text and send them to our program and check if the randomNumber and our response number is the same.
I did it with the different digit numbers.

Here is one example:

![image](https://user-images.githubusercontent.com/59121690/207817813-f6efd0a5-f9fa-47c5-9674-d94716a8da10.png)

Here is my TestHelper for generating random numbers and converting them to text: 

![image](https://user-images.githubusercontent.com/59121690/207817924-fbcf9cba-6851-4935-9131-919371d7579b.png)

![image](https://user-images.githubusercontent.com/59121690/207817973-5a3ad4b6-9f29-430c-bb5a-552655b9da6a.png)


Thank you for reading. :)
