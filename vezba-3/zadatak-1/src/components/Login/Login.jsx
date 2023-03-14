import React, { useState } from "react";
import { Link } from "react-router-dom";
import "./Login.css";
import { LoginUser } from "../../services/authService";

const Login = () => {
  const [user, setUser] = useState({
    username: "",
    password: "",
    name: "",
    lastname: "",
    email: "",
  });

  const handleSubmit = async (e) => {
    e.preventDefault();
    const res = await LoginUser(user);
    console.log(res);
    localStorage.setItem("token", res.data);
  };

  const handleChange = (e) => {
    setUser((prevUser) => {
      return { ...prevUser, [e.target.name]: e.target.value };
    });
  };

  return (
    <div className="form-container">
      <h1>Login</h1>
      <form onSubmit={handleSubmit}>
        <div className="form-group">
          <label>Username:</label>
          <input
            type="text"
            name="username"
            value={user.username}
            onChange={handleChange}
            required
          />
        </div>
        <div className="form-group">
          <label>Password:</label>
          <input
            type="password"
            name="password"
            value={user.password}
            onChange={handleChange}
            required
          />
        </div>
        <div className="form-group">
          <button type="submit">Submit</button>
        </div>
        <p>
          Don't have an account? <Link to="/register">Register</Link>
        </p>
      </form>
    </div>
  );
};

export default Login;
