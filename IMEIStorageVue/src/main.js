import Vue from 'vue';
import App from './App.vue';

import BootstrapVue from 'bootstrap-vue';
//import Bootstrap from 'bootstrap';

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

//import './app.scss'

Vue.use(BootstrapVue);

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
