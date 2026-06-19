1. ## AI(Artificial Intelligence)
- Ai is the board of field machine that performs the tasks that require the human intelligance

- Chatbots like Chatgpt
- voice assistances like  siri
- Self driving cars
- Recommendation 

### Goal of an AI
- To make computers 
- Think
- Learn
- Reason
- Solve problems
- Make Decisions

Example

using the google maps To find the best route .thats AI

2. ## Machine Learning

Machine learning is the subset of an AI

- Insted of manually give the rules , we actually provide the data to the computer that will learn by it self by using the patterns 

```python
Data + Output → Learn Rules
```

Example :

suppose if you wnat to identify the spam mails

- Insted of writing the 10000+ rules 

```python
if contains "Win money"
then spam
```

- Give the model

- 1000 spam mails
- 10000 normal mails

- It was learn by the patterns automatically


### Types of the Machine Learning

- They are 3 types

### Supervised Learning(Learning with the teacher)

- In supervised learning the data already containes the answer

- AI learns from the Example

Example Student Result Prediction

Training Data:

| Hours Studied | Result |
| ------------- | ------ |
| 2             | Fail   |
| 4             | Pass   |
| 6             | Pass   |
| 1             | Fail   |

- Here Hours Studied is the Input
- result = Correct answer

- By proving this data to the model it will learn like the the person who studied more hours they has to pass chances are high

Input = 6 then the automatically the output is Pass

### Unsupervised learning (Learn without Teacher)

- We provide the data no answer
- Itself it will find the answer
- It is like it will find the patterns

Example Student Grouping 

suppose we have the 

| Student | Age | Marks |
| ------- | --- | ----- |
| A       | 18  | 90    |
| B       | 19  | 88    |
| C       | 18  | 92    |
| D       | 22  | 45    |
| E       | 21  | 40    |

- Ai automatically find the pattern like this 

Group 1 ABC (High Marks)

Group 2 DE (Low marks)

- In above we not even told the groups it predicts automatically right

- This is called Clustering.

### Reinforcement Learning(Learn by the rewards and the punishments)

- This is how we actually learn

Think about riding bicycle
```python
Ride
 ↓
Fall
 ↓
Learn
 ↓
Ride Better
```
You learn through Experience

### Deep Learning

- Deep Learning is the subset of Machine Learning
- It uses stractures called neural Networks,Inspired by the human brain

why "Deep"?

- Because it has the many layers
```python
Input Layer
    ↓
Hidden Layer
    ↓
Hidden Layer
    ↓
Hidden Layer
    ↓
Output Layer
```

- It has the more layers "Deeper" the network

Examples

Deep Learning powers:

Face recognition

Speech recognition

Self-driving cars

Image generation


Real-World Example: Student Attendance System
AI

A system that automatically recognizes students and marks attendance.

ML

The system learns from student images and identifies faces.

DL

A deep neural network analyzes facial features like:

Eyes
Nose
Face shape
Distance between features

and recognizes the student accurately.


#### Mini project

```python
For Your AI Face Recognition Project

Since you're interested in the Iron Man–style face recognition system:

AI → The complete smart system.
ML → Learns to identify people from data.
DL → Recognizes faces using neural networks.
Computer Vision → Allows the camera to "see" faces.
Database → Stores student details.
Frontend + Backend → Displays information on screen.
```

```python

Python
    ↓
NumPy
    ↓
Pandas
    ↓
Machine Learning
    ↓
Deep Learning
    ↓
Computer Vision (OpenCV)
    ↓
Face Recognition
    ↓
Project Development
```