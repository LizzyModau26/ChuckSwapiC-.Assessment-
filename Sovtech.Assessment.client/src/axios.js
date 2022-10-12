import axios from "axios";

const instance = axios.create({
  baseURL: "http://localhost:7223",
});



export default instance;