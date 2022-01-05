import Vue from 'vue'
import App from './App.vue'
import router from './router'
import { BootstrapVue, BootstrapVueIcons }from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import Axios from 'axios'

Vue.config.productionTip = false;

Axios.defaults.baseURL = process.env.VUE_APP_API_ENDPOINT;

Vue.use(BootstrapVue);
Vue.use(BootstrapVueIcons);

new Vue({
  router,
  render: h => h(App)
}).$mount('#app');
