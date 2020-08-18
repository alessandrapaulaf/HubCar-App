import axios from 'axios';

const api = axios.create({
    baseURL: "https://localhost:44364/api",
});

axios.defaults.headers.post['Content-Type'] = 'application/json';

export default api;