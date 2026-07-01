### Isomorphic String

Given two strings s and t, determine if they are isomorphic. Two strings s and t are isomorphic if the characters in s can be replaced to get t.



All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.


Example 1

Input : s = "egg" , t = "add"

Output : true

Explanation :

The 'e' in string s can be replaced with 'a' of string t.

The 'g' in string s can be replaced with 'd' of t.

Hence all characters in s can be replaced to get t.

Example 2

Input : s = "apple" , t = "bbnbm"

Output : false

Explanation :

Strings are matched index by index.

At index 0, 'a' maps to 'b'.

At index 1, 'p' also maps to 'b'.

This is invalid because two different characters (a and p) cannot map to the same character (b) in a one-to-one mapping.

Therefore, no valid mapping exists and the output is false.



### code

```python
class Solution:
    def isomarpic(self,s,t):
        n=len(s)
        map1={}
        map2={}
        for i in range(n):
            if map1.get(s[i])!=map2.get(t[i]):
                return False
            map1[s[i]]=i
            map2[t[i]]=i
        return True
print(Solution().isomarpic("egh","add"))
```


### code visual type explanation


```javascript
const {
  Array2DTracer,
  LogTracer,
  Layout,
  VerticalLayout,
  Tracer
} = require('algorithm-visualizer');

const gridTracer = new Array2DTracer('Comparison Grid');
const logTracer = new LogTracer('Console');

function solve(s, t) {
  const map1 = {};
  const map2 = {};

  const table = [
    ['idx', 's[i]', 't[i]', 'map1[s[i]]', 'map2[t[i]]']
  ];

  for (let i = 0; i < s.length; i++) {
    table.push([
      i,
      s[i],
      t[i],
      '',
      ''
    ]);
  }

  Layout.setRoot(
    new VerticalLayout([
      gridTracer,
      logTracer
    ])
  );

  gridTracer.set(table);
  Tracer.delay();

  for (let i = 0; i < s.length; i++) {

    const row = i + 1;

    const val1 = map1[s[i]];
    const val2 = map2[t[i]];

    logTracer.println(
      `\n========= Iteration ${i} =========`
    );

    logTracer.println(
      `Comparing '${s[i]}' with '${t[i]}'`
    );

    // Highlight current characters
    gridTracer.select(row, 1);
    gridTracer.select(row, 2);

    Tracer.delay();

    // Show current map values
    gridTracer.patch(row, 3, String(val1));
    gridTracer.patch(row, 4, String(val2));

    Tracer.delay();

    // Highlight map values being compared
    gridTracer.select(row, 3);
    gridTracer.select(row, 4);

    logTracer.println(
      `map1['${s[i]}'] = ${val1}`
    );

    logTracer.println(
      `map2['${t[i]}'] = ${val2}`
    );

    Tracer.delay();

    if (val1 !== val2) {

      logTracer.println(
        `❌ Mismatch Found`
      );

      logTracer.println(
        `${val1} !== ${val2}`
      );

      Tracer.delay();

      return false;
    }

    logTracer.println(
      `✅ Match Found`
    );

    map1[s[i]] = i;
    map2[t[i]] = i;

    logTracer.println(
      `Updating map1['${s[i]}'] = ${i}`
    );

    logTracer.println(
      `Updating map2['${t[i]}'] = ${i}`
    );

    gridTracer.patch(row, 3, i);
    gridTracer.patch(row, 4, i);

    Tracer.delay();

    // Remove highlights
    gridTracer.deselect(row, 1);
    gridTracer.deselect(row, 2);
    gridTracer.deselect(row, 3);
    gridTracer.deselect(row, 4);

    Tracer.delay();
  }

  logTracer.println('\n✅ Strings Are Isomorphic');

  return true;
}

// Test Cases
solve('egg', 'add');

// Try:
// solve('egg', 'ada');
// solve('egh', 'add');
```