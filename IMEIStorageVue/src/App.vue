<template>
    <div id="app">
        <div class="container">
            <div class="accordion-body">
                <div class="row mb-3">
                    <h2 class="display-6">IMEIStorage</h2>
                </div>
            </div>
        </div>
        <IMEIAddForm @add-imei="addImei" />
        <IMEIList v-bind:imeis="imeis"/>
    </div>

</template>

<script>
    import IMEIAddForm from '@/components/IMEIAddForm'
    import IMEIList from '@/components/IMEIList'


    export default {
        data(){
            return {
                imeis: null
            }
        },
        name: 'app',
        components: {
            IMEIList: IMEIList,
            IMEIAddForm: IMEIAddForm
        },
        mounted() {
            this.$api.ApiModule.getAll().then(response => this.imeis = response.data);
        },
        methods:
        {
            addImei(imei) {
                this.imeis.push(imei);
            }

        }
    };
</script>

<style>
</style>

