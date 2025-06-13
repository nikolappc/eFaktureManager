import { createStore } from 'vuex'
import axios from "axios";
var API_URL = 'https://localhost:'

export default createStore({
  state: {
    myInvoice
  },
  getters: {
  },
  mutations: {
  },
  actions: {

    fetchMyInvoices(){
      const invoices = [];
    
      return axios
        .get(API_URL)
        .then(response => {
          response.data.forEach(el => {
            console.log(el);
    
      
            invoices.push(el);
          });
        })
        .catch(e => {
          console.log(e);
        });


    }
  },
  modules: {
  }
})
