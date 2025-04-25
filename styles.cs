/* Reset CSS */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Righteous', sans-serif;
    line-height: 1.6;
    background-color: #f4f4f4;
    color: #333;
}

header {
    background: #333;
    color: #fff;
    padding: 10px 0;
}

.logo img {
    width: 100px;
}

nav ul {
    list-style: none;
    display: flex;
    justify-content: center;
}

nav ul li {
    margin: 0 15px;
}

nav ul li a {
    color: #fff;
    text-decoration: none;
}

.banner img {
    width: 100%;
    height: auto;
}

.welcome {
    text-align: center;
    padding: 20px;
}

.featured-articles {
    padding: 20px;
}

.featured-articles article {
    background: #fff;
    margin: 10px 0;
    padding: 15px;
    border-radius: 5px;
    box-shadow: 0 2px 5px rgba(0,0,0,0.1);
}

footer {
    text-align: center;
    padding: 10px 0;
    background: #333;
    color: #fff;
}

video {
     width="320" 
     height="240" controls
}