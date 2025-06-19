Frontend Code Challenge Answers

Question 1:
1.
firstDiv: red (class selector overrides element selector)
secondDiv: orange (ID selector overrides class selector)

2. document.getElementById('firstDiv').style.backgroundColor = 'pink';

3. document.getElementById('secondDiv').classList.add('yellow-card');


Question 2:
1. 
The function returns true because the == operator performs type coercion, converting the string "5" to the number 5 before comparison.
2.
To check both value and type: 
function compareIt(num1, num2) {
    return num1 === num2;
}


Question 3:
Making a page mobile friendly:
Use responsive design with media queries:
<--  CSS Example -->
@media (max-width: 768px) {
    .container {
        width: 100%;
        flex-direction: column;
    }
}

-Use flexible layouts (percentages or flex/grid)
-Set viewport meta tag:
<meta name="viewport" content="width=device-width, initial-scale=1">

Benefits of bundling JS:
-Reduces HTTP requests
-Improves load time
-Better compression
-Easier dependency management

For Sass:
-Use a Sass compiler (like node-sass) to convert to CSS Or use a build tool like Webpack with sass-loader

For ES6/7 compatibility:
-Use Babel to transpile to ES5
-Include polyfills for missing features
-Use module bundler like Webpack/Rollup
-Set appropriate Content-Type headers
