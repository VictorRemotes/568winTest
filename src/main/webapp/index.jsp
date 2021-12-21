<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>Hello World</title>
</head>
<body>
<h1><%= "Hello World!" %>
</h1>
<br/>
<%--<a href="hello-servlet">Hello Servlet</a>--%>
<script>
    function method1(){
        alert("Test Button");
    }
</script>
<button type="button" value="Button" onclick="method1()">Button</button>
</body>
</html>