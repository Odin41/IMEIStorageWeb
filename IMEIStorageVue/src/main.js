import Vue from 'vue';
import App from './App.vue';

import BootstrapVue from 'bootstrap-vue';

//import VueAxios from 'vue-axios'
//import Bootstrap from 'bootstrap';

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

//import './app.scss'

import ApiPlugin from './plugins/apiPlugin'

Vue.use(BootstrapVue);
Vue.use(ApiPlugin);
//Vue.use(VueAxios, axios);
Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
