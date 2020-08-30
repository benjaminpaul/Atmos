<template>
    <section id="create-mix">
        <div class="row">
            <div class="col-12">
                <h3>Like the way it sounds?<br/>Give it a name and Save it for later.</h3>
                <p>You can even share if with others who might like it.</p>
                <form @submit="checkForm">
                    <div class="form-group">
                        <div class="input-group">
                            <input type="text" v-model="mixName" class="form-control form-control-lg" placeholder="Give it a catchy name..." aria-label="Recipient's username" aria-describedby="basic-addon2">
                            <div class="input-group-append">
                                <button class="btn btn-lg btn-outline-light" type="submit">Save Mix</button>
                            </div>
                        </div>
                       
                    </div>
                </form>
            </div>
        </div>
    </section>
</template>

<script>
    export default {
        name: "CreateMix",
        data() {
            return {
                errors: [],
                mixName: ""
            }
        },
        methods: {
            checkForm(e) {
                this.errors = [];
                if (!this.mixName) {
                    this.errors.push('You forgot to give your mix a catchy name!');
                }
                
                if (this.mixName.length < 4) {
                    this.errors.push('Your mix name must be at least 4 characters long');
                }
                
                e.preventDefault();
            },
            saveMix() {
                console.log(`Save ${this.mixName}`)
            }
        }
    }
</script>

<style scoped>
    #create-mix {
        margin-bottom: 100px;
    }
    p {
        text-align: center;
    }
    h3 {
        text-align: center;
        margin-bottom: 20px;
    }
    .validation-error {
        font-weight: bold;
    }
    .validation-error > p.error-text {
        color: red;
    }
    form {
        padding-left: 50px;
        padding-right: 50px;
    }
</style>