import axios from 'axios';
import { Product } from '../models/product';
const RESOURCE_NAME = '/product';
const apiClient = axios.create();
const baseURL = `https://localhost:5001/api${RESOURCE_NAME}`

export default {
  getAll() {
    return apiClient.get<Array<Product>>(`${baseURL}`);
  },
  get(id: number) {
    return apiClient.get(`${baseURL}/${id}`);
  },
  create(data: any) {
    return apiClient.post(`${baseURL}`, data);
  },
  update(id: number, data : any) {
    return apiClient.put(`${baseURL}/${id}`, data);
  },
  delete(id: number) {
    return apiClient.delete(`${baseURL}/${id}`);
  }
};