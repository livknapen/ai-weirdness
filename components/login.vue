<template>
  <div>
    <form action="/home" class="login-form" method="POST">
      <input name="username" type="text" placeholder="username" required />
      <input name="password" type="password" placeholder="password" required />
      <input type="submit" value="Sign in" />
    </form>
    <a href="#" class="forgot-password">Forgot password?</a>
  </div>
</template>

<style>
.login-form {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}
.login-form {
  width: 100%;
  font-family: "Inter", sans-serif;

  input[type="text"] {
    padding: 14px;
    font-size: 20px;
    border-radius: 10px;
    border: none;
  }

  input[type="password"] {
    padding: 14px;
    font-size: 20px;
    border-radius: 10px;
    border: none;
  }

  input[type="submit"] {
    padding: 14px 0;
    background-color: black;
    color: white;
    border: none;
    border-radius: 10px;
    font-weight: bold;
    font-size: 20px;
  }
}

.forgot-password {
  font-family: "Inter", sans-serif;
  width: 100%;
  text-align: right;
  display: block;
  margin-top: 23px;

  text-decoration: none;
  color: white;
}
</style>
