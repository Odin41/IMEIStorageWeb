<template>
    <div>
        <b-container>
            <b-table hover :fields="fields" :items="imeis">
            </b-table>
        </b-container>
    </div>
</template>

<script>

    export default
        {
            props: ['imeis'],
            data() {
                return {
                    fields: [
                        { key: 'imei', label: "IMEI" },
                        {
                            key: 'addedDate',
                            label: "Дата добавления",
                            formatter: value => {
                                var date = new Date(value);
                                return date.toLocaleDateString() + ' ' + date.toLocaleTimeString();
                            }
                        }
                    ]
                }
            }
        }

</script>


