<template>
    <b-container>
        <b-row class="my-1">
            <b-col >
                <b-form-input v-model="imei" placeholder="Введите IMEI"></b-form-input>
            </b-col>
            <b-col>
                <b-button variant="outline-primary">Добавить</b-button>
            </b-col>
        </b-row>
</b-container>
</template>

<script>
  export default {
    data() {
      return {
        imei: ''
      }
    }
  }
</script>