import axios from 'axios'

const instance = axios.create({
    baseURL: 'http://localhost:5000',
    //withCredentials: true,
     headers: {
        //'Access-Control-Allow-Origin': '*',
        //'Access-Control-Allow-Methods': 'GET',
        //'Access-Control-Allow-Credentials': 'true',
        accept: 'application/json',
        //'Content-Type': 'application/json'
    }
})

export default instance