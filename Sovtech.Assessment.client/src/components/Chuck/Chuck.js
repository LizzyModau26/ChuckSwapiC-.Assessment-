import useAxios from 'axios-hooks';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import '../../assets/css/Chuck.css';




const RenderUserInfo = (props) => {
  const { name } = props;
  return (

    <Container>
      <Row>
        <Col xs>{name}</Col>
      </Row>
    </Container>
  );
};


function Chuck() {

  const [{ data, loading, error }, refetch] = useAxios(
    'categories'
  )

  if (loading) return <p>Loading...</p>
  if (error) return <p>Error!</p>

  return (
    <div>
      {data &&
        !error &&
        !loading &&
        data.map((item, index) => (
          <RenderUserInfo
            name={item}
            key={index}
          />
        ))}
      {loading && <p>Loading ...</p>}
      {error && (<p>{error.message}</p>)}
    </div>
  )
}
export default Chuck


