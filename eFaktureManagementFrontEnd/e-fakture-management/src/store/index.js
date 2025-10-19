import { createStore } from 'vuex'
import axios from "axios";
import InvoiceType from '@/util/InvoiceType';
var API_URL = 'https://localhost:'

export default createStore({
  state: {
    area: InvoiceType.PURCHASE,
    myInvoice: {}
  },
  getters: {
  },

  mutations: {
    updateArea(state, value) {
      state.area = value
    }
  },

  actions: {

    fetchMyInvoices() {
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
