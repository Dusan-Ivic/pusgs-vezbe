import axios from "axios";

export const RegisterUser = async (userData) => {
  return await axios.post(
    `${process.env.REACT_APP_API_URL}/registration`,
    userData
  );
};

export const LoginUser = async (userData) => {
  return await axios.post(`${process.env.REACT_APP_API_URL}/login`, userData);
};
