<template>
    <div>
        <b-container>
            <b-table hover :fields="fields" :items="items">
               
            </b-table>
        </b-container>
    </div>
</template>

<script>
    export default
        {
            data() {
                return {
                    fields: [{ key: 'imei', label: "IMEI" }, { key: 'addDate', label:"Дата добавления"}],
                    items: [{ imei:'22', addDate: 'sadasd'}]
                }
            }
        }

</script>


