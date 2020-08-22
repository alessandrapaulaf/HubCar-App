import React, {  } from 'react';
import { Button, Form, FormGroup, Input } from 'reactstrap';


const FormLogin = () => {
  return (
    <Form>
      <FormGroup>
        <Input type="email" id="exampleEmail" placeholder="Digite aqui seu email." />
      </FormGroup>
      <FormGroup>
        <Input type="password" id="examplePassword" placeholder="Senha" />
      </FormGroup>
      <Button className="button">Login</Button>
    </Form>
  );
}

export default FormLogin;

