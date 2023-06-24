using AutoMapper;
using PersonalBlog.Data.Repositories;
using PersonalBlog.Entity.Entities;
using PersonalBlog.Service.Services.Abstractions;

namespace PersonalBlog.Service.Services.Concrete;

public class CommentService : ICommentService
{
    private readonly IMapper _mapper;
    private readonly IRepository<Comment> _repository;
    public CommentService(IMapper mapper, IRepository<Comment> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }
}
