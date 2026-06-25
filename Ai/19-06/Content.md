#### What is LLM 
#### What is transforms 

## LLM

- It means Large language model 

##### Large

- It means Huge number of perameters (learned weights)

#### Language 

- It means human understandable language

#### Model 

- A mathematical function that is learn from the data


> So the llm is the ginat neural network trained to predict the next token in a sequence.


- In simply there are movie characture seen discussion so the first human was tell something in end they asked some question in that the model should many parameters its learn weights so that based on it automatically predict the new word by word in an order


- Like for exmaple you teach something like tha sun raises ______
- east 
- If you ask the students at first time may they not answer may be after 2 or 3 times they will say the answer for in there life long because they find out the pattern 


### How LLM is  Built

```python
Internet Data
      ↓
Tokenizer
      ↓
Tokens
      ↓
Embeddings
      ↓
Transformer Layers
      ↓
Prediction
```

## Step 1  Collect data

- The model needs the text 

- Sources are 
    - Books
    - Wikipedia
    - Documentation
    - Websites
    - Research 
    
## Step 2 Tokenization

- The model can't read words
- It Only understand the numbers

Example :

    I love Python

Becomes:

    ["I" ,"love","python"]

Tokens

Then.

    I       → 101
    love    → 256
    Python  → 893

Token ID's


## Step 3: Embeddings

Numbers alone don't contain meaning.

The model converts tokens into vectors.

Example:

    python

Becomes:

    [0.34, 0.89, -0.12, ...]

A vector with hundreda or thousands of dimentions

Word with the same meaning there are comming close together

```python
King   ↔ Queen

Dog    ↔ Puppy

Java   ↔ Python
```


## Step 4 TRANSFORMER

- This were the magic happens

- The transformer looks at all tokens together

Example

    TONY is learning java because he wants a job

when reading 

    he

The model learns 

    He -> TONY

This is called attention

### What is Attention?

Attention answers:

Which words are important?

Sentence:

    The dog chased the ball because it was moving.

Question:

    What was moving?

The model learns:

    it → ball

Attention helps connect words across the sentence.

## Step 5 Predict Next Token

- Suppose the input is 

    Java is a programming

The model claculates the based on there data

    language → 95%

    book → 2%

    animal → 0.1%

The heighest predict % is language

So the model will return 

    java is a programming language

### Why the Learning Happen

- Inside something called Parameters
- That parameters has the model knowledge

Example 

```python
Tiny model:
10,000 parameters

Small model:
1 million parameters

Modern LLM:
Billions of parameters
```

This parameters are stores the weights

Example

```java
0.342
-0.982
1.234
...
```

## Why Does an LLM Know So Many Things?

Because during training it has seen patterns from huge amounts of text.

Not because it memorizes everything.

It learns relationships.

### If YOU Want to Build an LLM

```python
Python
 ↓
NumPy
 ↓
Linear Algebra
 ↓
Statistics
 ↓
Machine Learning
 ↓
Neural Networks
 ↓
Deep Learning
 ↓
PyTorch
 ↓
Transformers
 ↓
Build Mini GPT
 ↓
Fine-Tuning
 ↓
RAG
 ↓
Agents
```