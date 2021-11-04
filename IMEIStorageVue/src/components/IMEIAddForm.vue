<template>
    <div class="mb-3">
        <b-container>
            <b-row class="my-1">
                <b-col>
                    <b-form-input v-model="imei" placeholder="Введите IMEI"></b-form-input>
                </b-col>
                <b-col>
                    <b-button variant="outline-primary" v-on:click="addImei">Добавить</b-button>
                </b-col>
            </b-row>
        </b-container>
    </div>
</template>

<script>
  export default {
        data() {
          return {
                newImei:null,
                imei: '',
            }
        },
        methods:
        {
            async addImei() {
                if (this.imei.trim()) {
                    await this.$api.ApiModule.addImei(this.imei).then(response => this.newImei = response.data);
                    this.$emit('add-imei', this.newImei);
                    this.imei = '';
                }
            }
        }
  }
</script>