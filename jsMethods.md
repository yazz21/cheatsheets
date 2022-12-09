# reverse the string without affecting the special char
``` js
g="AB-cd"
h=g.split(/[^A-Za-z]/)[0]+g.split(/[^A-Za-z]/)[1]
h.split("").reverse().join("")


function foo (f) {
for (let i = 0; i < f.length; i++) {
    if (f[i].match(/[^A-Za-z]/))
        l = i 
        k = f[i]
    }
h=f.split(/[^A-Za-z]/)[0] + k +  f.split(/[^A-Za-z]/)[1]
h.split("").reverse().join("")
}
```
# reverse the string
``` js
for (var i = str.length - 1; i >= 0; i--) { 
        newString += str[i]; }
```

# not alphabet
``` js
g.match(/[^A-Za-z]/)
```
# alphabet
``` js 
g.match(/[A-Za-z]/)
```
[link](me.md)
