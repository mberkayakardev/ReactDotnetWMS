import axios from "axios";
import type { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";

axios.defaults.baseURL = import.meta.env.VITE_API_BASE_URL;

axios.interceptors.response.use( response => {
    return response;
}, 
((error : AxiosError)  => {
    const {data, status} = error.response as AxiosResponse
    switch (status){
        case 400 : 
        toast.error(data.title)
        break;
        case 401 : 
        toast.error(data.title)
        break;
        case 500 : 
        toast.error(data.title)
        break;
        case 403 : 
        toast.error(data.title)
        break;
        case 404 : 
        toast.error(data.title)
        break;

        default: break;
    }
    return Promise.reject( error.response);
}))

const queries = {
  get: (url: string) => axios.get(url).then((response: AxiosResponse) => response.data),
  post: (url: string, body: {}) => axios.post(url, body).then((response: AxiosResponse) => response.data),
  put: (url: string, body: {}) => axios.put(url, body).then((response: AxiosResponse) => response.data),
  delete: (url: string) => axios.delete(url).then((response: AxiosResponse) => response.data),
};

export default queries; 
 