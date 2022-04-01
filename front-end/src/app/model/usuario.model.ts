export class Usuario {

    constructor(
        public  nombre:string,
        public  apellidos:string,
        public  direccion:string,
        public  telefono:string,
        public  userName:string,
        public  email:string,
        public  password?:string,            
        public  id?:string,
        public  roles?:Array<string>,
        public  idEmpresa?:number,
        public  token?:string
       ) {}

}